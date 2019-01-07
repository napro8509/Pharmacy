using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace PharmacyManager.Report
{
    public partial class HoaDonBanHang : DevExpress.XtraReports.UI.XtraReport
    {
        public HoaDonBanHang()
        {
            InitializeComponent();
        }
        public void InitData(string madonban, string ngayban, string loaidon, string solieu, string gia)
        {
            if (loaidon == "0")
            {
                this.LoaiDonBan.Text = "Thuốc Theo Đơn";

            }
            else if (loaidon == "1")
                this.LoaiDonBan.Text = "Thuốc Bán Lẻ";
            else this.LoaiDonBan.Text = "Thuốc Nhạy Cảm";
            if(solieu == "0")
            {
                lblSoLieu.Visible = false;
                SoLieu.Visible = false;
            }
            this.sqlDataSource2.Queries[0].Parameters[0].Value = madonban;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = madonban;
            this.sqlDataSource1.Fill();
            this.sqlDataSource2.Fill();

        }

    }
}
