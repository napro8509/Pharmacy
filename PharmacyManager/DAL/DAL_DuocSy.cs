using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DAL_DuocSy : BDConnect
    {
        DataTable dt = new DataTable();
        public SqlCommand cmd;
        public SqlDataReader dr;

        public DataTable Get_DuocSy()//Lấy tất thông tin nha cung cap               
        {
            try
            {
                SqlDataAdapter da;
                DataTable ds;
                string sqlstr = "";
                sqlstr = "select * from DUOCSY";
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

        public DataTable Get_TTDUOCSY(string MaDuocSy)         
        {
            try
            {
                SqlDataAdapter da;
                DataTable ds;
                string sqlstr = "";
                sqlstr = "select MaDuocSy,TenDuocSy,BangCap,CONVERT (varchar(10),NgayVaoLam, 101) as NgayVaoLam,Luong from DUOCSY where MaDuocSy='" + MaDuocSy + "'";
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
        public string Get_MaDuocSy()//Lấy tất thông tin thuốc                 
        {
            try
            {
                string ma;
                SqlDataAdapter da = new SqlDataAdapter();
                string sqlstr = "";
                sqlstr = "Select Top 1 MaDuocSy from DUOCSY ORDER BY MaDuocSy DESC";
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
        public string TaoMaDuocSY()//Lấy tất thông tin thuốc                 
        {
            try
            {
                string t = this.Get_MaDuocSy();
                string Ma = t.Substring(3);
                int a = int.Parse(Ma) + 1;
                int length = a.ToString().Length;
                Ma = "MDS";
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
    }
}
