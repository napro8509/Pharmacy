using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;
namespace PharmacyManager.UserControlMain
{
    public partial class TraThuocHetHan : DevExpress.XtraEditors.XtraUserControl
    {
        string MaDuocSy;
        public TraThuocHetHan(string MaDuocSy)
        {
            InitializeComponent();
            this.MaDuocSy = MaDuocSy;
        }
        BUS_DonNhap dn = new BUS_DonNhap();
        DateTime now = DateTime.Now;
        BUS_DonBan db = new BUS_DonBan();
        BUS_Kho kho = new BUS_Kho();

        private void TraThuocHetHan_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            grid_DSThuocSapHetHan.Width = this.Width / 2;
            BindingSource bs = new BindingSource();
            db.ThongKeTraHang();
            bs.DataSource = db.ThongKeTraHang().Tables["THUOC,CTDONTHUOC,DONBAN,CTDN,DONNHAP,CONGTY"];
            grid_DSTraThuoc.DataSource = bs;

            BindingSource _bs = new BindingSource();
            _bs.DataSource = kho.BaoCaoSapHetHan().Tables["KhoHang"];
            grid_DSThuocSapHetHan.DataSource = _bs;
        }


        private void sidePanel1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void grid_DSTraThuoc_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_TraThuoc_Click_1(object sender, EventArgs e)
        {
            string Ma = db.Get_TaoMaDonBan();

            DateTime now = DateTime.Today;
            string ngaythang = now.ToString();
            string[] tokens = ngaythang.Split(' ');
            ngaythang = tokens[0];
            db.TaoDonBan(Ma, 2, ngaythang, MaDuocSy, 0,0);

            DataRowView selectedRow = (DataRowView)gridView1.GetRow(gridView1.FocusedRowHandle);
            string MaThuoc = selectedRow.Row.ItemArray[0].ToString();
            string NgayHetHan = selectedRow.Row.ItemArray[2].ToString();
            string sl = selectedRow.Row.ItemArray[3].ToString();
            db.CTDB(MaThuoc, Ma, sl, NgayHetHan, 2, 0);
            BindingSource bs = new BindingSource();
            db.ThongKeTraHang();
            bs.DataSource = db.ThongKeTraHang().Tables["THUOC,CTDONTHUOC,DONBAN,CTDN,DONNHAP,CONGTY"];
            grid_DSTraThuoc.DataSource = bs;

            BindingSource _bs = new BindingSource();
            _bs.DataSource = kho.BaoCaoSapHetHan().Tables["KhoHang"];
            grid_DSThuocSapHetHan.DataSource = _bs;
        }
    }
}
