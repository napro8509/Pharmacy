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
    public partial class ThemTaiKhoanMoi : UserControl
    {
        public ThemTaiKhoanMoi()
        {
            InitializeComponent();
        }
        BUS_DuocSy ds = new BUS_DuocSy();
        DateTime now = DateTime.Now;
        BUS_TaiKhoan tk = new BUS_TaiKhoan();
        private void ThemTaiKhoanMoi_Load(object sender, EventArgs e)
        {
            txt_MaDuocSy.Text = ds.TaoMaDuocSY();
            rdb_dpBanThuoc.Checked = true;
            rdb_dpNhapThuoc.Checked = true;
            rdb_dpTaiKhoan.Checked = true;
            rdb_dpThongKe.Checked = true;
            addItem();
            ngay.SelectedIndex = now.Day - 1;
            thang.SelectedIndex = now.Month - 1;
            nam.SelectedIndex = now.Year - 2000;

        }
        void addItem()
        {
            for (int i = 1; i <= 12; i++)
                thang.Items.Add(i);
            for (int i = 2000; i < now.Year + 10; i++)
                nam.Items.Add(i);
            for (int i = 1; i <= 31; i++)
                ngay.Items.Add(i);
        }
        int LoaiCapNhat = 0;
        public void SetGT(string MaDuocSy, string TenDuocSy, string TaiKhoan, string MatKhau, string BangCap, int Luong, string NgayVaoLam, int dpBanThuoc, int dpNhapKho, int dpThongKe, int dpTaoTaiKhoan,int LoaiCapNhat=0)
        {
            btn_TaoTaiKhoan.Text = "Cập Nhật";
            txt_MaDuocSy.Text = MaDuocSy;
            txt_MaDuocSy.Enabled = false;
            txt_TenDuocSy.Text = TenDuocSy;
            txt_TaiKhoan.Text = TaiKhoan;
            txt_luong.Text = Luong.ToString(); ;
            string ntn = NgayVaoLam;
            SetNVL(ntn);
            string BC = BangCap;
            SetBangCap(BC);
            txt_MatKhau.Text = MatKhau;
            if (dpBanThuoc == 1)
                rdb_dpBanThuoc.Checked = true;
            else
                rdb_kdpBanThuoc.Checked = true;
            if (dpNhapKho == 1)
                rdb_dpNhapThuoc.Checked = true;
            else
                rdb_kdpNhapThuoc.Checked = true;
            if (dpThongKe == 1)
                rdb_dpThongKe.Checked = true;
            else
                rdb_kdpThongKe.Checked = true;
            if (dpTaoTaiKhoan == 1)
                rdb_dpTaiKhoan.Checked = true;
            else
                rdb_kdpTaiKhoan.Checked = true;
            this.LoaiCapNhat = LoaiCapNhat;
        }
        void SetNVL(string ipntn)
        {
            int _thang = 0;
            int _ngay = 1;
            //if (ktraNgay() == false)
            //{
            //    _thang = 1;
            //    _ngay = 0;
            //}
            string[] tokens = ipntn.Split('/');
            int a = int.Parse(tokens[_ngay]) - 1;
            ngay.SelectedIndex = a;
            a = int.Parse(tokens[_thang]) - 1;
            thang.SelectedIndex = a;
            string[] tokens_2 = tokens[2].Split(' ');
            a = int.Parse(tokens_2[0]) - 2000;
            nam.SelectedIndex = a;
        }
        int SetBangCap(string BangCap)
        {
            for (int i = 0; i < cbb_BangCap.Items.Count; i++)
            {
                cbb_BangCap.SelectedIndex = i;
                if (cbb_BangCap.Text == BangCap)
                    return i;

            }
            return 0;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void btn_TaoTaiKhoan_Click(object sender, EventArgs e)
        {
            string MaDuocSy = txt_MaDuocSy.Text;
            string TenDuocSy = txt_TenDuocSy.Text;
            string TaiKhoan = txt_TaiKhoan.Text;
            string MatKhau = txt_MatKhau.Text;
            string BangCap = cbb_BangCap.Text;
            int Luong = int.Parse(txt_luong.Text);
            string NgayVaoLam = thang.Text + "/" + ngay.Text + "/" + nam.Text;
            if (ktraNgay() == false)
                NgayVaoLam =  ngay.Text + "/" + thang.Text + "/" + nam.Text;
            int dpBanThuoc = 0;
            int dpNhapKho = 0;
            int dpThongKe = 0;
            int dpTaoTaiKhoan = 0;
            if (rdb_dpBanThuoc.Checked == true)
                dpBanThuoc = 1;
            if (rdb_dpNhapThuoc.Checked == true)
                dpNhapKho = 1;
            if (rdb_dpThongKe.Checked == true)
                dpThongKe = 1;
            if (rdb_dpTaiKhoan.Checked == true)
                dpTaoTaiKhoan = 1;
            if (txt_MaDuocSy.Enabled == false)
            {
                tk.CapNhatDuocSy(MaDuocSy, TenDuocSy, BangCap, NgayVaoLam, Luong);
                tk.CapNhatTaiKhoan(TaiKhoan, MatKhau, MaDuocSy);
                tk.CapNhatQuyen(TaiKhoan, dpBanThuoc, dpNhapKho, dpThongKe, dpTaoTaiKhoan);
            }
            else
            {
                tk.TaoDuocSy(MaDuocSy, TenDuocSy, BangCap, NgayVaoLam, Luong);
                tk.NhapTaiKhoanMoi(TaiKhoan, MatKhau, MaDuocSy);
                tk.TaoQuyen(TaiKhoan, dpBanThuoc, dpNhapKho, dpThongKe, dpTaoTaiKhoan);
            }
            
            if(LoaiCapNhat==0)
                this.ParentForm.Close();
            lbl_ThongBao.Text = "Bạn Đã Cập Nhật Tài Khoản Thành Công";
        }
        bool ktraNgay()
        {
            DateTime now = DateTime.Today;
            string ngaythang = now.ToString();
            string[] tokens = ngaythang.Split(' ');
            ngaythang = tokens[0];
            string[] token_1 = ngaythang.Split('/');
            int ngay_1 = int.Parse(token_1[1]);
            int thang_1 = int.Parse(token_1[0]);
            int nam_2 = int.Parse(token_1[2]);
            if (thang_1 == now.Month && ngay_1 == now.Day)
                return true;
            return false;
        }
    }
}
