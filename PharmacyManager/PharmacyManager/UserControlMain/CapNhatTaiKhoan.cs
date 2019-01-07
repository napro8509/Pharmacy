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
    public partial class CapNhatTaiKhoan : UserControl
    {
        string MaDuocSy;
        public BUS_TaiKhoan tk = new BUS_TaiKhoan();
        public CapNhatTaiKhoan(string MaDuocSy)
        {
            this.MaDuocSy = MaDuocSy;
            InitializeComponent();
        }
        ThemTaiKhoanMoi ucThemThuoc = new ThemTaiKhoanMoi();
        private void CapNhatTaiKhoan_Load(object sender, EventArgs e)
        {
            string TenDuocSy = tk.Get_TTTaiKhoan(MaDuocSy).Rows[0]["TenDuocSy"].ToString();
            string TaiKhoan = tk.Get_TTTaiKhoan(MaDuocSy).Rows[0]["TaiKhoan"].ToString();
            string MatKhau = tk.Get_TTTaiKhoan(MaDuocSy).Rows[0]["MatKhau"].ToString();
            string BangCap = tk.Get_TTTaiKhoan(MaDuocSy).Rows[0]["BangCap"].ToString();
            int Luong = int.Parse(tk.Get_TTTaiKhoan(MaDuocSy).Rows[0]["Luong"].ToString());
            string NgayVaoLam = tk.Get_TTTaiKhoan(MaDuocSy).Rows[0]["NgayVaoLam"].ToString();
            int dpBanThuoc = int.Parse(tk.Get_TTTaiKhoan(MaDuocSy).Rows[0]["BanThuoc"].ToString());
            int dpNhapKho = int.Parse(tk.Get_TTTaiKhoan(MaDuocSy).Rows[0]["NhapThuoc"].ToString());
            int dpThongKe = int.Parse(tk.Get_TTTaiKhoan(MaDuocSy).Rows[0]["ThongKe"].ToString());
            int dpTaoTaiKhoan = int.Parse(tk.Get_TTTaiKhoan(MaDuocSy).Rows[0]["TaoTaiKhoan"].ToString());
            this.Controls.Add(ucThemThuoc);
            ucThemThuoc.SetGT(MaDuocSy, TenDuocSy, TaiKhoan, MatKhau, BangCap, Luong, NgayVaoLam, dpBanThuoc, dpNhapKho, dpThongKe, dpTaoTaiKhoan,1);
        }
    }
}
