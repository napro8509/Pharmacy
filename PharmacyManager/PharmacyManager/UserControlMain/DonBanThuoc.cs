using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DevExpress.Utils;
using System.Diagnostics;

namespace PharmacyManager.UserControlMain
{
    public partial class DonBanThuoc : UserControl
    {
        BUS_THUOC thuoc = new BUS_THUOC();
        BUS_DuocSy ds = new BUS_DuocSy();
        BUS_Kho kho = new BUS_Kho();
        BUS_DonBan db = new BUS_DonBan();
        private List<Thuoc> th = new List<Thuoc>();
        string MaDuocSy;
        public DonBanThuoc(String MaDuocSy)
        {
            this.MaDuocSy = MaDuocSy;
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            sidePanel1.Width = this.Width / 2;
        }

        private void DonBanThuoc_Load(object sender, EventArgs e)
        {
            cbb_LoaiDonThuoc.SelectedIndex = 0;
            this.ActiveControl = txt_mathuoc;
            sidePanel1.Width = this.Width / 2;


            for(int i=1;i<=9;i++)
            {
                string name="0"+i.ToString() + " -  Liều";
                cbb_SoLieu.Items.Add(name);
            }
            for (int i = 10; i <= 15; i++)
            {
                string name = i.ToString() + " -  Liều";
                cbb_SoLieu.Items.Add(name);
            }
            cbb_SoLieu.SelectedIndex = 2;
        }
        int a = 0;
        private void btn_nhapthuoc_Click(object sender, EventArgs e,int _slThuoc=1)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            int sl = 0;
            if (a == 0)
            {
                foreach (Thuoc A in th)
                {
                    if (string.Equals(txt_mathuoc.Text, A.getMaSanPham()))
                    {
                        sl += A.getsl();
                    }
                }
            }
            if (kho.Check_Exist(txt_mathuoc.Text, cbb_LoaiDonThuoc.SelectedIndex) > sl)
            {
                a = 0;
                int t = int.Parse(thuoc.Get_GiaTriThuoc(txt_mathuoc.Text).Rows[0]["Vien"].ToString());
                //int t = 1;
                Thuoc X = new Thuoc(t);
                X.setSTT(th.Count() + 1);
                X.setMaSanPham(txt_mathuoc.Text);
                X.setTenThuoc(thuoc.Get_GiaTriThuoc(txt_mathuoc.Text).Rows[0]["TenThuoc"].ToString());
                X.setGiaSauThue(thuoc.Get_GiaTriThuoc(txt_mathuoc.Text).Rows[0]["GiaBan"].ToString());
                string hsd = kho.Get_GiaTriThuocTrongKho(txt_mathuoc.Text).Rows[0]["NgayHetHan"].ToString();
                string[] tokens = hsd.Split(' ');
                hsd = tokens[0];

                //X.Location = new System.Drawing.Point(0, X._stt * 30);
                X.ButtonClick += new EventHandler(this.thuoc_ButtonClick);
                X.ButtonClick_more += new EventHandler(this.thuoc_ButtonClick_more);

                int tt;
                foreach (Thuoc A in th)
                {
                    A.getsl();
                    if (A.getMaSanPham() == txt_mathuoc.Text)
                    {
                        A.setsl();
                        tt = tongtien(th);
                        alltien.Text = tt.ToString();
                        return;
                    }
                }
                th.Add(X);
                panel1.Controls.Add(X);


                tt = tongtien(th);
                alltien.Text = tt.ToString();
                setlist(th);
                X.setNTN(hsd);


            }
            else if (kho.Check_Exist(txt_mathuoc.Text, cbb_LoaiDonThuoc.SelectedIndex) > 0)
            {

                int t = int.Parse(thuoc.Get_GiaTriThuoc(txt_mathuoc.Text).Rows[0]["Vien"].ToString());
                a = 1;
                Thuoc X = new Thuoc(t);
                X.setSTT(th.Count() + 1);
                X.setMaSanPham(txt_mathuoc.Text);
                X.setTenThuoc(kho.Add_ThemLoaiThuocKhac(txt_mathuoc.Text).Rows[0]["TenThuoc"].ToString());
                X.setGiaSauThue(thuoc.Get_GiaTriThuoc(txt_mathuoc.Text).Rows[0]["GiaBan"].ToString());
                string hsd = kho.Add_ThemLoaiThuocKhac(txt_mathuoc.Text).Rows[0]["NgayHetHan"].ToString();
                string[] tokens = hsd.Split(' ');
                hsd = tokens[0];

                X.Location = new System.Drawing.Point(0, X._stt * 30);
                X.ButtonClick += new EventHandler(this.thuoc_ButtonClick);
                X.ButtonClick_more += new EventHandler(this.thuoc_ButtonClick_more);
                int tt;
                foreach (Thuoc A in th)
                {
                    A.getsl();
                    if (A.getMaSanPham() == txt_mathuoc.Text && string.Equals(A.getNTN(), hsd))
                    {
                        A.setsl();
                        tt = tongtien(th);
                        alltien.Text = tt.ToString();
                        return;
                    }
                }
                th.Add(X);

                panel1.Controls.Add(X);
                tt = tongtien(th);
                alltien.Text = tt.ToString();
                setlist(th);
                X.setsl(_slThuoc);
                X.setNTN(hsd);
            }
            txt_mathuoc.Text = "";
            timer.Stop();
            string k = "Time Taken: " + timer.Elapsed.TotalMilliseconds.ToString("#,##0.00 'milliseconds'");
            int l = 0;
        }
        void NhapThuoc()
        {

        }
        int tongtien(List<Thuoc> th)
        {
            int all = 0;
            for (int i = 0; i < th.Count; i++)
            {
                all += th[i].getTien();
            }
            return all;
        }
        void setlist(List<Thuoc> th)
        {
            if (th.Count == 0)
                return;

            for (int i = 0; i < th.Count; i++)
            {
                th[i]._stt = i + 1;
                th[i].setSTT(i + 1);
                th[i].Location = new System.Drawing.Point(0, (i + 1) * 30);
            }
        }
        private void thuoc_ButtonClick(object sender, EventArgs e)
        {
            th.RemoveAll(r => r.gt == 1);
            panel1.Controls.Clear();
            setlist(th);
            foreach (Thuoc x in th)
            {
                panel1.Controls.Add(x);
            }
            if (th.Count == 0)
                alltien.Text = "";

        }

        private void thuoc_ButtonClick_more(object sender, EventArgs e)
        {
            try
            {
                foreach (Thuoc x in th)
                {
                    int sl = 0;
                    foreach (Thuoc A in th)
                    {
                        if (string.Equals(x.getMaSanPham(), A.getMaSanPham()) && string.Equals(x.getNTN(), A.getNTN()))
                        {
                            sl += A.getsl();
                            if (sl < kho.Check_Exist(x.getMaSanPham(), cbb_LoaiDonThuoc.SelectedIndex))
                            {
                                x.onbuttonmore();
                            }
                        }
                    }
                    if ((kho.Check_Exist(x.getMaSanPham(), cbb_LoaiDonThuoc.SelectedIndex) < sl) /*&& a == 0*/)
                    {
                        x.offbuttonmore();
                        x.setsl(kho.Check_Exist(x.getMaSanPham(), cbb_LoaiDonThuoc.SelectedIndex));
                        txt_mathuoc.Text = x.getMaSanPham();
                        int k = sl - kho.Check_Exist(x.getMaSanPham(), cbb_LoaiDonThuoc.SelectedIndex);
                        btn_nhapthuoc_Click(null, null, k);
                    }
                    int tt = tongtien(th);
                    alltien.Text = tt.ToString();
                    string MaThuoc = x.getMaSanPham();
                    int t = int.Parse(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["Vien"].ToString());
                    if (t == 1)
                    {
                        int LoaiSl = x.GetLoaiSL();
                        if (LoaiSl == 0)
                            x.setGiaSauThue(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["GiaVien"].ToString());
                        else if (LoaiSl == 1)
                            x.setGiaSauThue(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["GiaVi"].ToString());
                        else if (LoaiSl == 2)
                            x.setGiaSauThue(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["GiaBan"].ToString());
                    }
                    else
                    {
                        int LoaiSl = x.GetLoaiSL();
                        if (LoaiSl == 0)
                            x.setGiaSauThue(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["GiaGoi"].ToString());
                        else if (LoaiSl == 1)
                            x.setGiaSauThue(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["GiaBan"].ToString());
                    }
                    x.updateTongTien();
                    if (x.getsl() == 1)
                    {
                        x.offbuttonless();
                    }
                    else
                    {
                        x.onbuttonless();
                    }

                }

            }
            catch
            {

            }
        }

        private void txt_mathuoc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_mathuoc.Text != "")
            {
                btn_nhapthuoc_Click(null, null);
                txt_mathuoc.Text = "";
            }
        }

        private void btn_BanThuoc_Click(object sender, EventArgs e)
        {
            if (th.Count == 0)
            {
                //lbl_ThongBao.Text = "Vui Lòng Nhập Thuốc";
            }
            else
            {
                
                string Ma = db.Get_TaoMaDonBan();
                DateTime now = DateTime.Today;
                string ngaythang = now.ToString();
                string[] tokens = ngaythang.Split(' ');
                ngaythang = tokens[0];
                int GiaTien = int.Parse(alltien.Text);
                int SoLieu = 0;
                if (cbb_LoaiDonThuoc.SelectedIndex == 0)
                    SoLieu = cbb_SoLieu.SelectedIndex+1;
                db.TaoDonBan(Ma, cbb_LoaiDonThuoc.SelectedIndex, ngaythang, MaDuocSy,SoLieu, GiaTien);
                foreach (Thuoc A in th)
                {
                    string ma_thuoc = A.getMaSanPham();
                    int sl = A.getsl();
                    int SL_Loai = 1;
                    int t = int.Parse(thuoc.Get_GiaTriThuoc(ma_thuoc).Rows[0]["Vien"].ToString());
                    if (t == 1)
                    {
                        int LoaiSl = A.GetLoaiSL();
                        if (LoaiSl == 0)
                            SL_Loai = int.Parse(thuoc.Get_GiaTriThuoc(ma_thuoc).Rows[0]["Vien"].ToString());
                        else if (LoaiSl == 1)
                            SL_Loai = int.Parse(thuoc.Get_GiaTriThuoc(ma_thuoc).Rows[0]["Vi"].ToString());
                        else if (LoaiSl == 2)
                            SL_Loai = int.Parse(thuoc.Get_GiaTriThuoc(ma_thuoc).Rows[0]["Hop"].ToString());
                    }
                    else
                    {
                        int LoaiSl = A.GetLoaiSL();
                        if (LoaiSl == 0)
                            SL_Loai = int.Parse(thuoc.Get_GiaTriThuoc(ma_thuoc).Rows[0]["Goi"].ToString());
                        else if (LoaiSl == 1)
                            SL_Loai = int.Parse(thuoc.Get_GiaTriThuoc(ma_thuoc).Rows[0]["Hop"].ToString());
                    }
                    sl = sl * SL_Loai;
                    //string Loaisl = A.GetLoaiSL().ToString();
                    string ntn = A.getNTN();
                    int Gia = A.getTien();
                    db.CTDB(ma_thuoc, Ma, sl.ToString(), ntn, 1, Gia);
                    A.setgt();
                }
                thuoc_ButtonClick(null, null);
                gridControl1_Load(null, null);
                //lbl_ThongBao.Text = "Bạn Vừa Mới Bán Thành Công Một Đơn Thuốc " + now.ToString();

            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView selectedRow = (DataRowView)gridView1.GetRow(gridView1.FocusedRowHandle);
                string maThuoc = selectedRow.Row.ItemArray[0].ToString();
                txt_mathuoc.Text = maThuoc;
            }
            catch (Exception ex)
            {

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            btn_nhapthuoc_Click(null, null);
            txt_mathuoc.Text = "";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                btn_nhapthuoc_Click(null, null);
                txt_mathuoc.Text = "";
            } catch(Exception ex)
            {

            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void sidePanel5_Click(object sender, EventArgs e)
        {

        }

        private void cbb_LoaiDonThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = kho.Get_Kho(cbb_LoaiDonThuoc.SelectedIndex).Tables["KhoHang,Thuoc"];
            gridControl1.DataSource = bs;
            if(cbb_LoaiDonThuoc.SelectedIndex==0)
            {
                cbb_SoLieu.Show();
            }
            else
            {
                cbb_SoLieu.Hide();
            }
        }

        private void cbb_SoLieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = kho.Get_Kho(cbb_LoaiDonThuoc.SelectedIndex).Tables["KhoHang,Thuoc"];
            gridControl1.DataSource = bs;
        }
    }
}
