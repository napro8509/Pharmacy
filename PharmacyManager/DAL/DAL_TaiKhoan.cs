using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DAL_TaiKhoan : BDConnect
    {
        DataTable dt = new DataTable();
        public SqlCommand cmd;
        public SqlDataReader dr;
        public string Get_MatKhau(string TaiKhoan)//Lấy tất thông tin thuốc                 
        {
            try
            {
                string matkhau;
                SqlDataAdapter da = new SqlDataAdapter();
                string sqlstr = "";
                sqlstr = "select MatKhau from TAIKHOAN where TaiKhoan='" + TaiKhoan + "'";
                da.InsertCommand = new SqlCommand(sqlstr, _cn);
                _cn.Open();
                matkhau = da.InsertCommand.ExecuteScalar().ToString();
                _cn.Close();
                return matkhau;
            }
            catch
            {
                return null;
            }
        }
        public DataTable Get_TTTaiKhoan(string MaDuocSy)             
        {
            try
            {
                SqlDataAdapter da;
                DataTable ds;
                string sqlstr = "";
                sqlstr = "select ds.MaDuocSy,ds.TenDuocSy,ds.BangCap,CONVERT (varchar(10), ds.NgayVaoLam, 101) 'NgayVaoLam',ds.Luong,tk.TaiKhoan,tk.MatKhau,q.BanThuoc,q.NhapThuoc,q.ThongKe,q.TaoTaiKhoan";
                sqlstr += " from DUOCSY ds,TAIKHOAN tk,QUYEN q";
                sqlstr += " where ds.MaDuocSy=tk.MaDuocSy and tk.TaiKhoan=q.TaiKhoan and ds.MaDuocSy='" + MaDuocSy + "'";
                da = new SqlDataAdapter(sqlstr, _cn);
                _cn.Open();
                ds = new DataTable();
                ds.Clear();
                da.Fill(ds);
                _cn.Close();
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public string Get_TenDuocSy(string TaiKhoan)//Lấy tất thông tin thuốc                 
        {
            try
            {
                string tenduocsy;
                SqlDataAdapter da = new SqlDataAdapter();
                string sqlstr = "";
                sqlstr = "select ds.TenDuocSy from TAIKHOAN tk, DUOCSY ds where tk.MaDuocSy=ds.MaDuocSy and tk.TaiKhoan='" + TaiKhoan + "'";
                da.InsertCommand = new SqlCommand(sqlstr, _cn);
                _cn.Open();
                tenduocsy = da.InsertCommand.ExecuteScalar().ToString();
                _cn.Close();
                return tenduocsy;
            }
            catch
            {
                return null;
            }
        }
        public string Get_MaDuocSy(string TaiKhoan)//Lấy tất thông tin thuốc                 
        {
            try
            {
                string tenduocsy;
                SqlDataAdapter da = new SqlDataAdapter();
                string sqlstr = "";
                sqlstr = "select ds.MaDuocSy from TAIKHOAN tk, DUOCSY ds where tk.MaDuocSy=ds.MaDuocSy and tk.TaiKhoan='" + TaiKhoan + "'";
                da.InsertCommand = new SqlCommand(sqlstr, _cn);
                _cn.Open();
                tenduocsy = da.InsertCommand.ExecuteScalar().ToString();
                _cn.Close();
                return tenduocsy;
            }
            catch
            {
                return null;
            }
        }
        public bool NhapTaiKhoanMoi(string TaiKhoan, string MatKhau, string MaDuocSy)
        {
            _cn.Open();

            string SQL = "INSERT INTO TAIKHOAN (TaiKhoan, MatKhau, MaDuocSy) VALUES ('" + TaiKhoan + "', '" + MatKhau + "', '" + MaDuocSy + "');";

            SqlCommand cmd = new SqlCommand(SQL, _cn);
            cmd.ExecuteNonQuery();
            _cn.Close();
            return true;
        }
        public bool CapNhatTaiKhoan(string TaiKhoan, string MatKhau, string MaDuocSy)
        {
            _cn.Open();
            string SQL = "UPDATE TAIKHOAN ";
            SQL += " SET MatKhau='" + MatKhau + "' where MaDuocSy='" + MaDuocSy + "'";

            SqlCommand cmd = new SqlCommand(SQL, _cn);
            cmd.ExecuteNonQuery();
            _cn.Close();
            return true;
        }

        public bool TaoDuocSy(string MaDuocSy, string TenDuocSy, string BangCap, string NgayVaoLam, int Luong)
        {
            _cn.Open();

            string SQL = "INSERT INTO DUOCSY (MaDuocSy, TenDuocSy, BangCap, NgayVaoLam, Luong)";
            SQL += " VALUES ('" + MaDuocSy + "', N'" + TenDuocSy + "', N'" + BangCap + "', '" + NgayVaoLam + "', " + Luong + ");";
            SqlCommand cmd = new SqlCommand(SQL, _cn);
            cmd.ExecuteNonQuery();
            _cn.Close();
            return true;
        }
        public bool CapNhatDuocSy(string MaDuocSy, string TenDuocSy, string BangCap, string NgayVaoLam, int Luong)
        {
            _cn.Open();

            string SQL = "UPDATE DUOCSY ";
            SQL += " SET TenDuocSy=N'" + TenDuocSy + "',BangCap=N'" + BangCap + "',NgayVaoLam='" + NgayVaoLam + "',Luong='" + Luong + "' where MaDuocSy='" + MaDuocSy + "'";
            SqlCommand cmd = new SqlCommand(SQL, _cn);
            cmd.ExecuteNonQuery();
            _cn.Close();
            return true;
        }
        public bool TaoQuyen(string TaiKhoan, int BanThuoc, int NhapThuoc, int ThongKe, int TaoTaiKhoan)
        {
            _cn.Open();

            string SQL = "INSERT INTO QUYEN (TaiKhoan, BanThuoc, NhapThuoc,ThongKe,TaoTaiKhoan) ";
            SQL += " VALUES ('" + TaiKhoan + "', " + BanThuoc + ", " + NhapThuoc + "," + ThongKe + "," + TaoTaiKhoan + ");";
            SqlCommand cmd = new SqlCommand(SQL, _cn);
            cmd.ExecuteNonQuery();
            _cn.Close();
            return true;
        }
        public bool CapNhatQuyen(string TaiKhoan, int BanThuoc, int NhapThuoc, int ThongKe, int TaoTaiKhoan)
        {
            _cn.Open();

            string SQL = "UPDATE QUYEN ";
            SQL += " SET BanThuoc='" + BanThuoc + "',NhapThuoc='" + NhapThuoc + "',ThongKe='" + ThongKe + "',TaoTaiKhoan='" + TaoTaiKhoan + "' where TaiKhoan='" + TaiKhoan + "'";
            SqlCommand cmd = new SqlCommand(SQL, _cn);
            cmd.ExecuteNonQuery();
            _cn.Close();
            return true;
        }
        public DataSet DSTaiKhoan()//Lấy tất thông tin thuốc                 
        {
            try
            {
                SqlDataAdapter da;
                DataSet ds;
                string sqlstr = "select ds.MaDuocSy,ds.TenDuocSy,ds.BangCap,CONVERT (varchar(10), ds.NgayVaoLam, 101) as NgayVaoLam,ds.Luong,tk.*,q.* from DUOCSY ds,TAIKHOAN tk, QUYEN q ";
                sqlstr += "where ds.MaDuocSy=tk.MaDuocSy and tk.TaiKhoan=q.TaiKhoan";
                da = new SqlDataAdapter(sqlstr, _cn);
                ds = new DataSet();
                ds.Clear();
                da.Fill(ds, "DUOCSY,TAIKHOAN,QUYEN");
                return ds;
            }
            catch
            {
                return null;
            }
        }

        public DataTable QuyenTaiKhoan(string TaiKhoan)             
        {
            try
            {
                SqlDataAdapter da;
                DataTable ds;
                string sqlstr = "";
                sqlstr = "select * from QUYEN where TaiKhoan='" + TaiKhoan + "'";
                da = new SqlDataAdapter(sqlstr, _cn);
                _cn.Open();
                ds = new DataTable();
                ds.Clear();
                da.Fill(ds);
                _cn.Close();
                return ds;
            }
            catch
            {
                return null;
            }
        }

    }
}
