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
    public class BUS_DonBan
    {
        DAL_DonBan db = new DAL_DonBan();
        public DataSet Get_ThongKeBan()
        {
            return db.Get_ThongKeBan();
        }
        public bool XoaCTDB(string MaDonBan)
        {
            return db.XoaCTDB(MaDonBan);
        }
        public DataSet Get_ThongKeTheoNam(string nam,string thang,string ngay,string MaDuocSy,bool ThuocNhayCam)
        {
            return db.Get_ThongKeTheoNam(nam, thang, ngay, MaDuocSy, ThuocNhayCam);
        }
        public DataSet Get_ThongKeKhoangTime(string nam, string thang, string ngay, string MaDuocSy, string nam_2, string thang_2, string ngay_2, bool ThuocNhayCam)
        {
            return db.Get_ThongKeKhoangTime(nam, thang, ngay, MaDuocSy, nam_2, thang_2, ngay_2, ThuocNhayCam);
        }
        public DataTable Get_AllDoanhThu()
        {
            return db.Get_AllDoanhThu();
        }
        public bool TaoDonBan(string MaDonBan, int LoaiDon, string NgayBan, string MaDuocSy, int SoLieu, int Gia)
        {
            return db.TaoDonBan(MaDonBan, LoaiDon, NgayBan, MaDuocSy,SoLieu,Gia);
        }
        public string Get_TaoMaDonBan()
        {
            return db.Get_TaoMaDonBan();
        }
        public bool CTDB(string MaThuoc, string MaDonBan, string sl, string ngayhethan,int LoaiDonThuoc, int Gia )
        {
            return db.CTDB(MaThuoc, MaDonBan, sl, ngayhethan, LoaiDonThuoc, Gia);
        }
        public DataSet ThongKeTraHang()
	    {		
	        return db.ThongKeTraHang();		
	    }
        public DataSet CTDonThuoc(string MaDonThuoc)
        {
            return db.CTDonThuoc(MaDonThuoc);
        }
        public DataSet Get_ThongKeTheoMaDon(string MaDonBan)
        {
            return db.Get_ThongKeTheoMaDon(MaDonBan);
        }
        public bool UpdateDonBan(string MaThuoc, int SoLieu)
        {
            return db.UpdateDonBan(MaThuoc, SoLieu);
        }
        public DataSet Get_ThongKeSoLuongThuoc(string nam, string thang, string ngay)
        {
            return db.Get_ThongKeSoLuongThuoc(nam, thang, ngay);
        }
        public DataSet Get_SoLuongKhoangTime(string nam, string thang, string ngay, string nam_2, string thang_2, string ngay_2)
        {
            return db.Get_SoLuongKhoangTime(nam, thang, ngay, nam_2, thang_2, ngay_2);
        }
}
}
