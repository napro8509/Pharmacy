using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DAL_NhaCungCap : BDConnect
    {
        DataTable dt = new DataTable();
        public SqlCommand cmd;
        public SqlDataReader dr;
        

        public void Connection_Close()
        {
            _cn.Close();
        }
        public int Check_SQL()//Kiểm tra xem trong DB có nha cung cap nào không
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from CONGTY", _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int row = dt.Rows.Count;
            if (row != 0)
                return 1;
            else
                return 0;
            ;
        }

        public string Get_MaNhaCC()//Lấy tất thông tin thuốc                 
        {
            try
            {
                string ma;
                SqlDataAdapter da = new SqlDataAdapter();
                string sqlstr = "";
                sqlstr = "Select Top 1 MaCongTy from CONGTY ORDER BY MaCongTy DESC";
                da.InsertCommand = new SqlCommand(sqlstr, _cn);
                _cn.Open();
                ma = da.InsertCommand.ExecuteScalar().ToString();
                _cn.Close();
                return ma;
            }
            catch
            {
                _cn.Close();
                return null;
            }
        }

        public string Get_TaoMaNhaCC()//Lấy tất thông tin thuốc                 
        {
            try
            {
                string t = this.Get_MaNhaCC();
                string Ma = t.Substring(3);
                int a = int.Parse(Ma) + 1;
                int length = a.ToString().Length;
                Ma = "MCT";
                for (int i = length; i < 3; i++)
                {
                    Ma += "0";
                }
                Ma += a.ToString();
                return Ma;
            }
            catch
            {
                return null;
            }
        }
        
        public DataSet Get_CONGTY()//Lấy tất thông tin nha cung cap               
        {
            try
            {
                SqlDataAdapter da;
                DataSet ds;
                string sqlstr = "";
                sqlstr = "select MaCongTy 'Mã Công Ty', TenCongTy 'Tên Công Ty', DiaChi 'Địa Chỉ' from CONGTY";
                da = new SqlDataAdapter(sqlstr, _cn);
                ds = new DataSet();
                ds.Clear();
                da.Fill(ds, "CONGTY");
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public DataTable Get_TENCONGTY()//Lấy tất thông tin nha cung cap               
        {
            try
            {
                SqlDataAdapter da;
                DataTable ds;
                string sqlstr = "";
                sqlstr = "select * from CONGTY";
                da = new SqlDataAdapter(sqlstr, _cn);
                ds = new DataTable();
                ds.Clear();
                da.Fill(ds);
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public DataTable Get_TENCONGTY(string macty)//Lấy tất thông tin nha cung cap               
        {
            try
            {
                SqlDataAdapter da;
                DataTable ds;
                string sqlstr = "";
                sqlstr = "select * from CONGTY where MaCongTy='" + macty + "'";
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
        public bool ThemNhaCungCap(string MaNhaCC, string TenNhaCC, string DiaChi)
        {
            _cn.Open();

            string SQL = "INSERT INTO CONGTY (MaCongTy, TenCongTy, DiaChi) VALUES";
            SQL += "  ('" + MaNhaCC + "', N'" + TenNhaCC + "', N'" + DiaChi + "');";

            SqlCommand cmd = new SqlCommand(SQL, _cn);
            cmd.ExecuteNonQuery();
            _cn.Close();
            return true;
        }
        public bool CapNhatNhaCungCap(string MaNhaCC, string TenNhaCC, string DiaChi)
        {
            _cn.Open();

            string SQL = "UPDATE CONGTY set TenCongTy=N'"+TenNhaCC+"', DiaChi=N'"+DiaChi+"'";
            SQL += " where MaCongTy='"+MaNhaCC+"'";

            SqlCommand cmd = new SqlCommand(SQL, _cn);
            cmd.ExecuteNonQuery();
            _cn.Close();
            return true;
        }
    }
}
