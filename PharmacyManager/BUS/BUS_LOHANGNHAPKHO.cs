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
    public class BUS_LOHANGNHAPKHO
    {
        DAL_LOHANGNHAPKHO LoHangNhapKho = new DAL_LOHANGNHAPKHO();
        public DataSet Get_LOHANGNHAPKHO(string MaDonNhap)
        {
            return LoHangNhapKho.Get_LOHANGNHAPKHO(MaDonNhap);

        }
        public DataSet Get_CTDN(string t)
        {
            return LoHangNhapKho.Get_CTDN(t);

        }
    }
}
