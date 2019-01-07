using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace BUS
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan tk = new DAL_TaiKhoan();
        public string Get_MatKhau(string TaiKhoan)
        {
            return tk.Get_MatKhau(TaiKhoan);
        }
        public string Get_TenDuocSy(string TaiKhoan)
        {
            return tk.Get_TenDuocSy(TaiKhoan);
        }
        public string Get_MaDuocSy(string TaiKhoan)
        {
            return tk.Get_MaDuocSy(TaiKhoan);
        }
        public bool TaoDuocSy(string MaDuocSy, string TenDuocSy, string BangCap, string NgayVaoLam, int Luong)
        {
            return tk.TaoDuocSy(MaDuocSy, TenDuocSy, BangCap, NgayVaoLam, Luong);
        }
        public bool CapNhatDuocSy(string MaDuocSy, string TenDuocSy, string BangCap, string NgayVaoLam, int Luong)
        {
            return tk.CapNhatDuocSy(MaDuocSy, TenDuocSy, BangCap, NgayVaoLam, Luong);
        }
        public bool NhapTaiKhoanMoi(string TaiKhoan, string MatKhau, string MaDuocSy)
        {
            return tk.NhapTaiKhoanMoi(TaiKhoan, MatKhau, MaDuocSy);
        }
        public bool CapNhatTaiKhoan(string TaiKhoan, string MatKhau, string MaDuocSy)
        {
            return tk.CapNhatTaiKhoan(TaiKhoan, MatKhau, MaDuocSy);
        }
        public bool TaoQuyen(string TaiKhoan, int BanThuoc, int NhapThuoc, int ThongKe, int TaoTaiKhoan)
        {
            return tk.TaoQuyen(TaiKhoan, BanThuoc, NhapThuoc, ThongKe, TaoTaiKhoan);
        }
        public bool CapNhatQuyen(string TaiKhoan, int BanThuoc, int NhapThuoc, int ThongKe, int TaoTaiKhoan)
        {
            return tk.CapNhatQuyen(TaiKhoan, BanThuoc, NhapThuoc, ThongKe, TaoTaiKhoan);
        }
        public DataSet DSTaiKhoan()
        {
            return tk.DSTaiKhoan();
        }
        public DataTable Get_TTTaiKhoan(string MaDuocSy)
        {
            return tk.Get_TTTaiKhoan(MaDuocSy);
        }
        public DataTable QuyenTaiKhoan(string TaiKhoan)
        {
            return tk.QuyenTaiKhoan(TaiKhoan);
        }
    }
}
