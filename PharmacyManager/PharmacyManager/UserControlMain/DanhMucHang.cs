using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace PharmacyManager.UserControlMain
{
    public partial class DanhMucHang : UserControl
    {
        BUS_THUOC thuoc = new BUS_THUOC();
        public DanhMucHang()
        {
            InitializeComponent();
        }

        private void DanhMucHang_Load(object sender, EventArgs e)
        {
            cbb_LoaiThuoc.SelectedIndex = 4;
            BindingSource bs = new BindingSource();
            bs.DataSource = thuoc.Get_THUOC(cbb_LoaiThuoc.SelectedIndex).Tables["THUOC"];
            gridControl1.DataSource = bs;
            this.Dock = DockStyle.Fill;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            NhapThuoc formNhapThuoc = new NhapThuoc();
            formNhapThuoc.ShowDialog();
            DanhMucHang_Load(null, null);
        }

        private void btn_CapNhatThuoc_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)gridView1.GetRow(gridView1.FocusedRowHandle);
            string MaThuoc = selectedRow.Row.ItemArray[0].ToString();
            string TenThuoc = selectedRow.Row.ItemArray[1].ToString();
            string HoatChat = selectedRow.Row.ItemArray[2].ToString();
            int GiaNhap = int.Parse(selectedRow.Row.ItemArray[3].ToString());
            int GiaSauThue = int.Parse(selectedRow.Row.ItemArray[4].ToString());
            int GiaBan = int.Parse(selectedRow.Row.ItemArray[5].ToString());
            int Vien = int.Parse(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["Vien"].ToString());
            int GiaVien = int.Parse(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["GiaVien"].ToString()); ;
            int Vi = int.Parse(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["Vi"].ToString()); ;
            int GiaVi = int.Parse(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["GiaVi"].ToString()); ;
            int Goi = int.Parse(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["Goi"].ToString()); ;
            int GiaGoi = int.Parse(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["GiaGoi"].ToString()); ;
            int Hop = int.Parse(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["Hop"].ToString()); ;
            float THSuDung = float.Parse(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["ThoiHanSuDung"].ToString()); ;
            int QuyDinh = int.Parse(thuoc.Get_GiaTriThuoc(MaThuoc).Rows[0]["QuyDinh"].ToString()); ;
            NhapThuoc formNhapThuoc = new NhapThuoc(MaThuoc, TenThuoc, HoatChat, GiaNhap, GiaSauThue, GiaBan, Hop, Vi, GiaVi, Vien, GiaVien, Goi, GiaGoi, QuyDinh, THSuDung);
            formNhapThuoc.ShowDialog();
            DanhMucHang_Load(null, null);
        }

        private void cbb_LoaiThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = thuoc.Get_THUOC(cbb_LoaiThuoc.SelectedIndex).Tables[0];
            gridControl1.DataSource = bs;
            this.Dock = DockStyle.Fill;
        }

        
    }
}
