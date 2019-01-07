using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyManager.UserControlMain;
namespace PharmacyManager
{
    public partial class ThemTaiKhoan : Form
    {
        ThemTaiKhoanMoi ucThemThuoc = new ThemTaiKhoanMoi();
        public ThemTaiKhoan()
        {
            InitializeComponent();
        }
        string MaDuocSy ;
        string TenDuocSy ;
        string TaiKhoan ;
        string MatKhau ;
        string BangCap ;
        int Luong ;
        string NgayVaoLam;
        int dpBanThuoc = 0;
        int dpNhapKho = 0;
        int dpThongKe = 0;
        int dpTaoTaiKhoan = 0;
        bool CapNhat = false;
        public ThemTaiKhoan(string MaDuocSy, string TenDuocSy, string TaiKhoan, string MatKhau, string BangCap, int Luong, string NgayVaoLam, int dpBanThuoc, int dpNhapKho, int dpThongKe, int dpTaoTaiKhoan,int LoaiCapNhat=0)
        {
            InitializeComponent();
            this.MaDuocSy = MaDuocSy;
            this.TenDuocSy = TenDuocSy;
            this.TaiKhoan = TaiKhoan;
            this.MatKhau = MatKhau;
            this.BangCap = BangCap;
            this.Luong = Luong;
            this.NgayVaoLam = NgayVaoLam;
            this.dpBanThuoc = dpBanThuoc;
            this.dpNhapKho = dpNhapKho;
            this.dpThongKe = dpThongKe;
            this.dpTaoTaiKhoan = dpTaoTaiKhoan;
            CapNhat = true;
        }

        private void ThemTaiKhoan_Load(object sender, EventArgs e)
        {
            this.Controls.Add(ucThemThuoc);
            if(CapNhat)
            {
                ucThemThuoc.SetGT(MaDuocSy, TenDuocSy, TaiKhoan, MatKhau, BangCap, Luong, NgayVaoLam, dpBanThuoc, dpNhapKho, dpThongKe, dpTaoTaiKhoan);
            }
        }
                
    }
}
