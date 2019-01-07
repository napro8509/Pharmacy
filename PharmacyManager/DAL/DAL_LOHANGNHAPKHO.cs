using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_LOHANGNHAPKHO : BDConnect
    {
        DataTable dt = new DataTable();
        public SqlCommand cmd;
        public SqlDataReader dr;

        public DataSet Get_LOHANGNHAPKHO(string MaDonNhap)//Lấy tất thông tin thuốc                 
        {
            try
            {
                SqlDataAdapter da;
                DataSet ds;
                string sqlstr = "select dn.MaDonNhap 'Mã Đơn Nhập',dn.MaCongTy 'Mã Công Ty',CONVERT (varchar(10), dn.NgayNhap, 101) 'Ngày Nhập' ,ds.TenDuocSy 'Tên Dược Sỹ' ";
                sqlstr += " from DONNHAP dn, DUOCSY ds where dn.MaDuocSy=ds.MaDuocSy and dn.MaDonNhap LIKE '%"+MaDonNhap+"%' order by NgayNhap DESC";
                da = new SqlDataAdapter(sqlstr, _cn);
                ds = new DataSet();
                ds.Clear();
                da.Fill(ds, "DONNHAP,DUOCSY");
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public DataSet Get_CTDN(string t)//Lấy tất thông tin thuốc                 
        {
            try
            {
                SqlDataAdapter da;
                DataSet ds;
                string sqlstr = "";
                sqlstr = "select ct.MaThuoc,ct.MaDonNhap,ct.SoLuong,CONVERT (varchar(10), ct.NgayHetHan, 101) as NgayHetHan from CTDN ct where ct.MaDonNhap='" + t + "'";
                da = new SqlDataAdapter(sqlstr, _cn);
                ds = new DataSet();
                ds.Clear();
                da.Fill(ds, "CTDN");
                return ds;
            }
            catch
            {
                return null;
            }
        }
    }
}
