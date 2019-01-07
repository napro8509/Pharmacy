using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyManager.Report;
using BUS;
namespace PharmacyManager
{
    public partial class PrintReport : DevExpress.XtraEditors.XtraForm
    {
        string MaDonBan;
        BUS_DonBan db = new BUS_DonBan();
        public PrintReport()
        {
            InitializeComponent();
        }
         public void initData()
        {
        }
        public void getData(string madonban)
        {
            this.MaDonBan = madonban;
        }
        public void print()
        {
            //BaoCao report = new BaoCao();
            //foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
            //    p.Visible = false;
            //report.initData(hd.GioBatDau, hd.GioKetThuc, hd.MaKhachHang, hd.Ngay, hd.MaHoaDonKhachHang, hd.TienGio, hd.TienAnUong, hd.TienThue, hd.TongCong,hd.MaPhong);
            //documentViewer1.DocumentSource = report;
            //report.CreateDocument();
          
            HoaDonBanHang hd = new HoaDonBanHang();
            db.GetDonBan(this.MaDonBan).Tables[0].Rows[0].ItemArray[0].ToString();
            string madonban = db.GetDonBan(this.MaDonBan).Tables[0].Rows[0].ItemArray[0].ToString();
            string ngayban = db.GetDonBan(this.MaDonBan).Tables[0].Rows[0].ItemArray[1].ToString();
            string loaidon = db.GetDonBan(this.MaDonBan).Tables[0].Rows[0].ItemArray[2].ToString();
            string solieu = db.GetDonBan(this.MaDonBan).Tables[0].Rows[0].ItemArray[3].ToString();
            string giaban = db.GetDonBan(this.MaDonBan).Tables[0].Rows[0].ItemArray[4].ToString();
            hd.InitData(madonban, ngayban, loaidon,solieu, giaban);
            foreach (DevExpress.XtraReports.Parameters.Parameter p in hd.Parameters)
                p.Visible = false;
            documentViewer1.DocumentSource = hd;
            hd.CreateDocument();
        }
        public void load()
        {
            //TongHopThuChi thuchi = new TongHopThuChi(this.tungay, this.denngay);
            ////Helpers.Instance.loadPhieuThu(thuchi,this.tungay, this.denngay);
            //foreach (DevExpress.XtraReports.Parameters.Parameter p in thuchi.Parameters)
            //    p.Visible = false;
            //documentViewer1.DocumentSource = thuchi;
            //thuchi.CreateDocument();
        }
        public void thongkethang()
        {
            //DoanhThuTheoThang doanhthu = new DoanhThuTheoThang();
            //foreach (DevExpress.XtraReports.Parameters.Parameter p in doanhthu.Parameters)
            //    p.Visible = false;
            //documentViewer1.DocumentSource = doanhthu;
            //doanhthu.CreateDocument();
        }
    }
}
