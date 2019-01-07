using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace PharmacyManager.UserControlMain
{
    public partial class BaoCaoBanHang : UserControl
    {
        BUS_DonBan db = new BUS_DonBan();
        BUS_DuocSy ds = new BUS_DuocSy();
        public BaoCaoBanHang()
        {
            InitializeComponent();
        }
        DateTime now = DateTime.Now;
        bool ThuocNhayCam = false;
        private void grid_baoCaoBanHang_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            grid_baoCaoBanHang.Width = this.Width / 2;
            addItem();
            cbb_DuocSy.Items.Add("*Tất cả dược sỹ*");
            foreach (DataRow dr in ds.Get_DuocSy().Rows)
            {
                cbb_DuocSy.Items.Add(dr["MaDuocSy"].ToString() + "  -  " + dr["TenDuocSy"].ToString());
            }
            cbb_DuocSy.SelectedIndex = 0;
            ngay.SelectedIndex = now.Day - 1;
            thang.SelectedIndex = now.Month - 1;
            nam.SelectedIndex = now.Year - 2000;
            ngay_2.SelectedIndex = now.Day - 1;
            thang_2.SelectedIndex = now.Month - 1;
            nam_2.SelectedIndex = now.Year - 2000;
            cbb_LoaiThongKe.SelectedIndex = 0;

            for (int i = 1; i <= 9; i++)
            {
                string name = "0" + i.ToString() + " -  Liều";
                cbb_SoLieu.Items.Add(name);
            }
            for (int i = 10; i <= 15; i++)
            {
                string name = i.ToString() + " -  Liều";
                cbb_SoLieu.Items.Add(name);
            }
            cbb_SoLieu.Hide();
        }
        void addItem()
        {
            for (int i = 1; i <= 12; i++)
            {
                thang.Items.Add(i);
                thang_2.Items.Add(i);
            }
            for (int i = 2000; i < now.Year + 10; i++)
            {
                nam.Items.Add(i);
                nam_2.Items.Add(i);
            }
            for (int i = 1; i <= 31; i++)
            {
                ngay.Items.Add(i);
                ngay_2.Items.Add(i);
            }
        }
        void HideAll()
        {
            
            ngay.Visible = false;
            thang.Visible = false;
            nam.Visible = false;
            ngay_2.Visible = false;
            thang_2.Visible = false;
            nam_2.Visible = false;
            txtNgay1.Visible = false;
            txtThang1.Visible = false;
            txtNam1.Visible = false;
            txtNgay2.Visible = false;
            txtThang2.Visible = false;
            txtNam2.Visible = false;
            //cbb_DuocSy.Visible = false;
        }
        private void cbb_LoaiThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaDuocSy;
            if(cbb_DuocSy.SelectedIndex == 0)
            {
                MaDuocSy = "";
            }
            else
            {
                string[] tokens = cbb_DuocSy.Text.Split(' ');
                MaDuocSy = tokens[0];
            }
            HideAll();
            if(cbb_LoaiThongKe.SelectedIndex==0)
            {
                
                ngay.Visible = true;
                thang.Visible = true;
                nam.Visible = true;
                txtNgay1.Visible = true;
                txtThang1.Visible = true;
                txtNam1.Visible = true;
                BindingSource bs = new BindingSource();
                db.Get_ThongKeTheoNam(nam.Text, thang.Text, ngay.Text, MaDuocSy, ThuocNhayCam);

                bs.DataSource = db.Get_ThongKeTheoNam(nam.Text, thang.Text, ngay.Text, MaDuocSy, ThuocNhayCam).Tables["DONBAN"];
                grid_baoCaoBanHang.DataSource = bs;
            }
            if(cbb_LoaiThongKe.SelectedIndex==1)
            {
                
                thang.Visible = true;
                nam.Visible = true;
                txtThang1.Visible = true;
                txtNam1.Visible = true;
                BindingSource bs = new BindingSource();
                db.Get_ThongKeTheoNam(nam.Text, thang.Text, "0", MaDuocSy, ThuocNhayCam);

                bs.DataSource = db.Get_ThongKeTheoNam(nam.Text, thang.Text, "0", MaDuocSy, ThuocNhayCam).Tables["DONBAN"];
                grid_baoCaoBanHang.DataSource = bs;
            }
            
            if (cbb_LoaiThongKe.SelectedIndex == 2)
            {
                nam.Visible = true;
                txtNam1.Visible = true;
                BindingSource bs = new BindingSource();
                db.Get_ThongKeTheoNam(nam.Text, "0", "0", MaDuocSy, ThuocNhayCam);

                bs.DataSource = db.Get_ThongKeTheoNam(nam.Text, "0", "0", MaDuocSy, ThuocNhayCam).Tables["DONBAN"];
                grid_baoCaoBanHang.DataSource = bs;
            }
            if (cbb_LoaiThongKe.SelectedIndex == 3)
            {
                ngay.Visible = true;
                thang.Visible = true;
                nam.Visible = true;
                ngay_2.Visible = true;
                thang_2.Visible = true;
                nam_2.Visible = true;
                txtNgay1.Visible = true;
                txtThang1.Visible = true;
                txtNam1.Visible = true;
                txtNgay2.Visible = true;
                txtThang2.Visible = true;
                txtNam2.Visible = true;
                BindingSource bs = new BindingSource();
                //db.Get_ThongKeKhoangTime(nam.Text, thang.Text, ngay.Text, MaDuocSy, nam_2.Text, thang_2.Text, ngay_2.Text);

                bs.DataSource = db.Get_ThongKeKhoangTime(nam.Text, thang.Text, ngay.Text, MaDuocSy, nam_2.Text, thang_2.Text, ngay_2.Text).Tables["DONBAN"];
                grid_baoCaoBanHang.DataSource = bs;
            }
            if (cbb_LoaiThongKe.SelectedIndex == 4)
            {
                cbb_DuocSy.Visible = true;
                BindingSource bs = new BindingSource();
                db.Get_ThongKeTheoNam(nam.Text, "0", "0", MaDuocSy, ThuocNhayCam);

                bs.DataSource = db.Get_ThongKeTheoNam(nam.Text, "0", "0", MaDuocSy, ThuocNhayCam).Tables["DONBAN"];
                grid_baoCaoBanHang.DataSource = bs;


            }
            if (cbb_LoaiThongKe.SelectedIndex == 5)
            {
                BindingSource bs = new BindingSource();
                db.Get_ThongKeTheoMaDon(txt_MaDonBan.Text);

                bs.DataSource = db.Get_ThongKeTheoMaDon(txt_MaDonBan.Text).Tables["DONBAN"];
                grid_baoCaoBanHang.DataSource = bs;


            }
            if (cbb_LoaiThongKe.SelectedIndex == 6)
            {
                BindingSource bs = new BindingSource();
                db.Get_ThongKeTheoMaDon(txt_MaDonBan.Text);

                bs.DataSource = db.Get_ThongKeTheoMaDon(txt_MaDonBan.Text).Tables["DONBAN"];
                grid_baoCaoBanHang.DataSource = bs;


            }
            try{
                DataRowView selectedRow = (DataRowView)gridView1.GetRow(gridView1.FocusedRowHandle);
                string t = selectedRow.Row.ItemArray[0].ToString();
                BindingSource b = new BindingSource();
                b.DataSource = db.CTDonThuoc(t).Tables["CTDONTHUOC,THUOC"];
                grid_CTDonThuoc.DataSource = b;
            }
            catch
            {

            }
        }

        private void nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_LoaiThongKe_SelectedIndexChanged(null,null);
        }

        private void ngay_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_LoaiThongKe_SelectedIndexChanged(null,null);
        }

        private void thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_LoaiThongKe_SelectedIndexChanged(null,null);
        }

        private void cbb_DuocSy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_LoaiThongKe_SelectedIndexChanged(null, null);
        }

        private void ngay_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_LoaiThongKe_SelectedIndexChanged(null, null);
        }

        private void thang_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_LoaiThongKe_SelectedIndexChanged(null, null);
        }

        private void nam_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_LoaiThongKe_SelectedIndexChanged(null, null);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void grid_baoCaoBanHang_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView selectedRow = (DataRowView)gridView1.GetRow(gridView1.FocusedRowHandle);
                string t = selectedRow.Row.ItemArray[0].ToString();
                BindingSource b = new BindingSource();
                b.DataSource = db.CTDonThuoc(t).Tables["CTDONTHUOC,THUOC"];
                grid_CTDonThuoc.DataSource = b;
            }
            catch
            {

            }
        }

        private void grid_CTDonThuoc_Load(object sender, EventArgs e)
        {
            //DataRowView selectedRow = (DataRowView)gridView1.GetRow(gridView1.FocusedRowHandle);
            //string t = selectedRow.Row.ItemArray[0].ToString();
            //BindingSource b = new BindingSource();
            //b.DataSource = db.CTDonThuoc(t).Tables["CTDONTHUOC,THUOC"];
            //grid_CTDonThuoc.DataSource = b;
        }

        private void BaoCaoBanHang_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            db.Get_ThongKeBan();
            bs.DataSource = db.Get_ThongKeBan().Tables["DONBAN"];
            grid_baoCaoBanHang.DataSource = bs;



        }
        private List<Thuoc> th = new List<Thuoc>();
        BUS_THUOC thuoc = new BUS_THUOC();
        private void btn_SuaDonNhap_Click(object sender, EventArgs e)
        {
            DataRowView selected_Row = (DataRowView)gridView1.GetRow(gridView1.FocusedRowHandle);
            int SoLieu = int.Parse(selected_Row.Row.ItemArray[2].ToString());
            if(SoLieu!=0)
            {
                cbb_SoLieu.Show();
                cbb_SoLieu.SelectedIndex = SoLieu - 1;
            }
            for (int i = 0; i < gridView2.DataRowCount; i++)
            {

                DataRowView selectedRow = (DataRowView)gridView2.GetRow(i);
                string MaThuoc = selectedRow.Row.ItemArray[0].ToString();
                int sl = int.Parse(selectedRow.Row.ItemArray[2].ToString());
                int t = int.Parse(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["Vien"].ToString());
                Thuoc X = new Thuoc(t);
                X.setSTT(th.Count() + 1);
                X.setMaSanPham(MaThuoc);
                X.setTenThuoc(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["TenThuoc"].ToString());
                if (t == 1)
                {
                    X.setGiaSauThue(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["GiaVien"].ToString());
                    X.setGiaNhap(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["GiaVien"].ToString());
                }
                else if (t == 0)
                {
                    X.setGiaSauThue(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["GiaGoi"].ToString());
                    X.setGiaNhap(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["GiaGoi"].ToString());
                }
                X.ButtonClick += new EventHandler(this.thuoc_ButtonClick);
                X.ButtonClick_more += new EventHandler(this.thuoc_ButtonClick_more);
                int tt;
                foreach (Thuoc A in th)
                {
                    if (A.getMaSanPham() == MaThuoc)
                    {
                        A.setsl();
                        tt = tongtien(th);
                        alltien.Text = tt.ToString();
                        return;
                    }
                }
                th.Add(X);
                panel1.Controls.Add(X);
                X.setNTN(selectedRow.Row.ItemArray[4].ToString(),1);
                X.setsl(sl);
                //X.SelectLoaiSL(false);
                //if (t == 1)
                //    X.SetKieuSL(2);
                //else
                //    X.SetKieuSL(1);
                //tt = tongtien(th);
                //alltien.Text = tt.ToString();
                //setlist(th);
            }
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
                //th[i].Location = new System.Drawing.Point(0, (i + 1) * 30);
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
            foreach (Thuoc x in th)
            {
                int sl = 0;


                //string MaThuoc = x.getMaSanPham();
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
                //x.setGiaSauThue(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["GiaVien"].ToString());
                x.updateTongTien();
                int tt = tongtien(th);
                alltien.Text = tt.ToString();
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

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)gridView1.GetRow(gridView1.FocusedRowHandle);
            string MaDonBan = selectedRow.Row.ItemArray[0].ToString();
            int SoLieu = int.Parse(selectedRow.Row.ItemArray[2].ToString());
            if (SoLieu != 0)
            {
                SoLieu = cbb_SoLieu.SelectedIndex + 1;
                db.UpdateDonBan(MaDonBan, SoLieu);
            }
            cbb_SoLieu.Hide();
            db.XoaCTDB(MaDonBan);
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
                string ntn = A.getNTN();
                int Gia = A.getTien();
                db.CTDB(ma_thuoc, MaDonBan, sl.ToString(), ntn, 1, Gia);
                A.setgt();
            }
            
            thuoc_ButtonClick(null, null);
            grid_baoCaoBanHang_Click(null, null);
            cbb_LoaiThongKe_SelectedIndexChanged(null, null);
        }

        private void btn_nhapthuoc_Click(object sender, EventArgs e)
        {
            if (thuoc.Check_Exist(txt_mathuoc.Text) == 1)
            {
                int t = int.Parse(thuoc.Get_GiaTriThuoc(txt_mathuoc.Text).Rows[0]["Vien"].ToString());

                Thuoc X = new Thuoc(t);
                X.setSTT(th.Count() + 1);
                X.setMaSanPham(txt_mathuoc.Text);
                X.setTenThuoc(thuoc.Get_GiaTriThuoc(txt_mathuoc.Text).Rows[0]["TenThuoc"].ToString());
                X.setGiaSauThue(thuoc.Get_GiaTriThuoc(txt_mathuoc.Text).Rows[0]["GiaVien"].ToString());

                X.setGiaNhap(thuoc.Get_GiaTriThuoc(txt_mathuoc.Text).Rows[0]["GiaVien"].ToString());

                //X.Location = new System.Drawing.Point(0, X._stt * 30);
                X.ButtonClick += new EventHandler(this.thuoc_ButtonClick);
                X.ButtonClick_more += new EventHandler(this.thuoc_ButtonClick_more);
                int tt;
                foreach (Thuoc A in th)
                {
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
                X.setNTN(thuoc.Get_ThoiHanSuDung(txt_mathuoc.Text));

                //X.SelectLoaiSL(false);
                //if (t == 1)
                //    X.SetKieuSL(2);
                //else
                //    X.SetKieuSL(1);

            }
        }

        private void txt_mathuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_mathuoc.Text != "")
            {
                btn_nhapthuoc_Click(null, null);
                txt_mathuoc.Text = "";
            }
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void txt_MaDonBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_MaDonBan_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txt_MaDonBan_KeyUp(object sender, KeyEventArgs e)
        {
            cbb_LoaiThongKe_SelectedIndexChanged(null, null);
        }

        private void cb_ThuocNhayCam_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ThuocNhayCam.Checked == true)
                ThuocNhayCam = true;
            else
                ThuocNhayCam = false;
            cbb_LoaiThongKe_SelectedIndexChanged(null, null);
        }
    }
}
