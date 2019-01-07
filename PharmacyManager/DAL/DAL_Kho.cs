using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DAL_Kho : BDConnect
    {
        DataTable dt = new DataTable();
        public SqlCommand cmd;
        public SqlDataReader dr;
        public DataSet Get_Kho()          
        {
            try
            {
                SqlDataAdapter da;
                DataSet ds;
                string sqlstr = "";
                sqlstr = "select MaThuoc,TenThuoc,CONVERT (varchar(10),NgayHetHan, 101) as NgayHetHan,SoLuong from KhoHang where SoLuong>0";
                da = new SqlDataAdapter(sqlstr, _cn);
                ds = new DataSet();
                ds.Clear();
                da.Fill(ds, "KhoHang");
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public DataSet Get_Kho(int LoaiThuoc)
        {
            try
            {
                SqlDataAdapter da;
                DataSet ds;
                string sqlstr = "select t.MaThuoc,t.TenThuoc,t.GiaBan,CONVERT (varchar(10),kh.NgayHetHan, 101) as NgayHetHan,kh.SoLuong";
                sqlstr += " from KhoHang kh,Thuoc t where kh.MaThuoc=t.MaThuoc and kh.SoLuong>0 and t.QuyDinh";
                if (LoaiThuoc == 1)
                    sqlstr+= "=1";
                if (LoaiThuoc == 2)
                    sqlstr += "=2";
                if(LoaiThuoc==0)
                    sqlstr += "!=2  and t.QuyDinh!=3";
                da = new SqlDataAdapter(sqlstr, _cn);
                ds = new DataSet();
                ds.Clear();
                da.Fill(ds, "KhoHang,Thuoc");
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public int Check_Exist(string MaThuoc,int LoaiThuoc)
        {
            try
            {
                int check;
                SqlDataAdapter da = new SqlDataAdapter();
                string sqlstr = "select Top 1 kh.SoLuong from KhoHang kh,Thuoc t ";
                sqlstr += " where kh.MaThuoc=t.MaThuoc and t.MaThuoc='" + MaThuoc + "' and kh.SoLuong>0";
                if(LoaiThuoc==1||LoaiThuoc==2)
                    sqlstr += "  and t.QuyDinh=" + LoaiThuoc;
                else if(LoaiThuoc==0)
                    sqlstr += "  and t.QuyDinh!=2 and t.QuyDinh!=3";
                da.InsertCommand = new SqlCommand(sqlstr, _cn);
                _cn.Open();
                check = int.Parse(da.InsertCommand.ExecuteScalar().ToString());
                _cn.Close();
                return check;
            }
            catch
            {
                _cn.Close();
                return -1;
            }
        }
        public DataTable Add_ThemLoaiThuocKhac(string MaThuoc)
        {
            try
            {
                SqlDataAdapter da;
                DataTable ds;
                string sqlstr = "select top 2 * from KhoHang where MaThuoc='"+MaThuoc+"' and SoLuong>0 ";
                sqlstr += "EXCEPT select top 1 *  from KhoHang where MaThuoc='"+MaThuoc+"' and SoLuong>0";
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
                _cn.Close();
                return null;
            }
        }
        public DataTable Get_GiaTriThuocTrongKho(string MaThuoc)
        {
            try
            {
                SqlDataAdapter da;
                DataTable ds;
                string sqlstr = "";
                sqlstr = "select top 1 * from KhoHang where MaThuoc = '"+MaThuoc+"' and SoLuong>0";
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
        public DataSet BaoCaoSapHetHan()
        {
            try
            {
                SqlDataAdapter da;
                DataSet ds;
                string sqlstr = "select MaThuoc 'Mã Thuốc',TenThuoc 'Tên Thuốc',CONVERT (varchar(10),NgayHetHan, 101) 'Ngày Hết Hạn',SoLuong 'Số Lượng' ";
                sqlstr += "from KhoHang where DATEDIFF(day, GETDATE() , NgayHetHan) < 30 and SoLuong>0";
                da = new SqlDataAdapter(sqlstr, _cn);
                ds = new DataSet();
                ds.Clear();
                da.Fill(ds, "KhoHang");
                return ds;
            }
            catch
            {
                return null;
            }
        }
    }

}
