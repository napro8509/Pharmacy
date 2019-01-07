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
    public class BUS_DonNhap
    {
        DAL_DonNhap dn = new DAL_DonNhap();
        public string Get_TaoMaDonNhap()
        {
            return dn.Get_TaoMaDonNhap();
        }
        public bool TaoDonNhap(string MaDonNhap, string NgayNhap, string MaCongTy, string MaDuocSy)
        {
            return dn.TaoDonNhap(MaDonNhap, NgayNhap, MaCongTy, MaDuocSy);
        }
        public DataSet Get_ThongKeKho()
        {
            return dn.Get_ThongKeKho();
        }
        public string Get_SoLuong(string MaThuoc, string NgayHetHan)
	    {		
	        return dn.Get_SoLuong(MaThuoc, NgayHetHan);		
	    }		
	    public string Get_TenCongTy(string MaThuoc, string NgayHetHan)
	    {		
	        return dn.Get_TenCongTy(MaThuoc, NgayHetHan);		
	    }
        public bool XoaCTDN(string MaDonNhap)
        {
            return dn.XoaCTDN(MaDonNhap);
        }
        public DataSet Get_ThongKeTheoNam(string nam, string thang, string ngay)
        {
            return dn.Get_ThongKeTheoNam(nam, thang, ngay);
        }
        public DataSet Get_ThongKeKhoangTime(string nam, string thang, string ngay, string nam_2, string thang_2, string ngay_2)
        {
            return dn.Get_ThongKeKhoangTime(nam, thang, ngay, nam_2, thang_2, ngay_2);
        }
    }
}
