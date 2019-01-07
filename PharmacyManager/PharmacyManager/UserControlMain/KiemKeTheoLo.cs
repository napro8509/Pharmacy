using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;
namespace PharmacyManager.UserControlMain
{
    public partial class KiemKeTheoLo : DevExpress.XtraEditors.XtraUserControl
    {
        BUS_LOHANGNHAPKHO lh = new BUS_LOHANGNHAPKHO();
        BUS_DonNhap dn = new BUS_DonNhap();
        public KiemKeTheoLo()
        {
            InitializeComponent();
        }

        private void KiemKeTheoLo_Load(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = new BindingSource();
                //lh.Get_LOHANGNHAPKHO();
                            bs.DataSource = lh.Get_LOHANGNHAPKHO(txt_MaDonNhap.Text).Tables["DONNHAP,DUOCSY"];
                grid_KiemKeTheoLo.DataSource = bs;
                this.Dock = DockStyle.Fill;
                grid_KiemKeTheoLo.Width = this.Width / 2;

                DataRowView selectedRow = (DataRowView)gridView1.GetRow(gridView1.FocusedRowHandle);
                string t = selectedRow.Row.ItemArray[0].ToString();
                BindingSource b = new BindingSource();
                lh.Get_CTDN(t);
                b.DataSource = lh.Get_CTDN(t).Tables["CTDN"];
                grid_CTDN.DataSource = b;
            }
            catch (Exception ex)
            {

            }
        }

        private List<Thuoc> th = new List<Thuoc>();
        BUS_THUOC thuoc = new BUS_THUOC();

        private void btn_SuaDonNhap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView2.DataRowCount; i++)
            {

                DataRowView selectedRow = (DataRowView)gridView2.GetRow(i);
                string MaThuoc = selectedRow.Row.ItemArray[0].ToString();
                int sl = int.Parse(selectedRow.Row.ItemArray[2].ToString());
                int slMoiHop = int.Parse(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["Hop"].ToString());
                sl = sl / slMoiHop;
                int t = int.Parse(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["Vien"].ToString());
                Thuoc X = new Thuoc(t);
                X.setSTT(th.Count() + 1);
                X.setMaSanPham(MaThuoc);
                X.setTenThuoc(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["TenThuoc"].ToString());
                X.setGiaSauThue(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["GiaSauThue"].ToString());
                X.setGiaNhap(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["GiaNhap"].ToString());

                //else if (cbb_LoaiDonNhap.SelectedIndex == 1)
                //{
                //    X.setGiaSauThue(thuoc.Get_GiaTriThuoc(txt_mathuoc.Text).Rows[0]["GiaBan"].ToString());
                //    X.setGiaNhap("");
                //}
                //X.Location = new System.Drawing.Point(0, X._stt * 30);
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
                X.setNTN(selectedRow.Row.ItemArray[3].ToString(),1);
                X.setsl(sl);
                X.SelectLoaiSL(false);
                if (t == 1)
                    X.SetKieuSL(2);
                else
                    X.SetKieuSL(1);
                //tt = tongtien(th);
                //alltien.Text = tt.ToString();
                //setlist(th);
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)gridView1.GetRow(gridView1.FocusedRowHandle);
            string MaDonNhap = selectedRow.Row.ItemArray[0].ToString();
            dn.XoaCTDN(MaDonNhap);
            foreach (Thuoc A in th)
            {
                string ma_thuoc = A.getMaSanPham();
                string sl = A.getsl().ToString();
                string SLMoiHop = thuoc.Get_GiaTriThuoc(A.getMaSanPham()).Rows[0]["Hop"].ToString();
                sl = (int.Parse(sl) * int.Parse(SLMoiHop)).ToString();
                string ntn = A.getNTN();
                thuoc.NhapThuoc(ma_thuoc, MaDonNhap, sl, ntn);
                A.setgt();
            }
            thuoc_ButtonClick(null, null);
            grid_KiemKeTheoLo_Click(null, null);
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
                X.setGiaSauThue(thuoc.Get_GiaTriThuoc(txt_mathuoc.Text).Rows[0]["GiaSauThue"].ToString());

                X.setGiaNhap(thuoc.Get_GiaTriThuoc(txt_mathuoc.Text).Rows[0]["GiaNhap"].ToString());

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

                X.SelectLoaiSL(false);
                if (t == 1)
                    X.SetKieuSL(2);
                else
                    X.SetKieuSL(1);

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

                
                string MaThuoc = x.getMaSanPham();
                x.setGiaSauThue(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["GiaSauThue"].ToString());
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

        private void txt_mathuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_mathuoc.Text != "")
            {
                btn_nhapthuoc_Click(null, null);
                txt_mathuoc.Text = "";
            }
        }

        private void grid_KiemKeTheoLo_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView selectedRow = (DataRowView)gridView1.GetRow(gridView1.FocusedRowHandle);
                string t = selectedRow.Row.ItemArray[0].ToString();

                BindingSource b = new BindingSource();
                lh.Get_CTDN(t);
                b.DataSource = lh.Get_CTDN(t).Tables["CTDN"];
                grid_CTDN.DataSource = b;
            }
            catch
            {

            }
        }

        private void txt_MaDonNhap_KeyUp(object sender, KeyEventArgs e)
        {
            BindingSource bs = new BindingSource();
                        bs.DataSource = lh.Get_LOHANGNHAPKHO(txt_MaDonNhap.Text).Tables["DONNHAP,DUOCSY"];
            grid_KiemKeTheoLo.DataSource = bs;

            grid_KiemKeTheoLo_Click(null, null);

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            btn_CapNhat_Click(null, null);
        }
    }
}
