using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace PharmacyManager.UserControlMain
{
    public partial class TinhGiaVon : UserControl
    {
        public TinhGiaVon()
        {
            InitializeComponent();
        }
        DateTime now = DateTime.Now;
        BUS_DonNhap dn = new BUS_DonNhap();
        BUS_DonBan db = new BUS_DonBan();
        void addItem()
        {
            for (int i = 1; i <= 12; i++)
            {
                thang.Items.Add(i);
                thang_2.Items.Add(i);
            }
            for (int i = 2000; i < now.Year + 10; i++)
            {
                nam.Items.Add(i);
                nam_2.Items.Add(i);
            }
            for (int i = 1; i <= 31; i++)
            {
                ngay.Items.Add(i);
                ngay_2.Items.Add(i);
            }
        }
        void HideAll()
        {

            ngay.Visible = false;
            thang.Visible = false;
            nam.Visible = false;
            txtNgay.Visible = false;
            txtThang.Visible = false;
            txtNam.Visible = false;
            ngay_2.Visible = false;
            thang_2.Visible = false;
            nam_2.Visible = false;
            txtNgay2.Visible = false;
            txtThang2.Visible = false;
            txtNam2.Visible = false;
        }

        private void TinhGiaVon_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            addItem();

            ngay.SelectedIndex = now.Day - 1;
            thang.SelectedIndex = now.Month - 1;
            nam.SelectedIndex = now.Year - 2000;
            ngay_2.SelectedIndex = now.Day - 1;
            thang_2.SelectedIndex = now.Month - 1;
            nam_2.SelectedIndex = now.Year - 2000;
            cbb_LoaiThongKe.SelectedIndex = 0;
        }
        void TinhTongGia()
        {
            int TongVon = 0;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRowView selectedRow = (DataRowView)gridView1.GetRow(i);
                int Tien;
                try
                {
                    Tien = int.Parse(selectedRow.Row.ItemArray[5].ToString());
                }
                catch
                {
                    Tien = 0;
                }
                TongVon += Tien;
            }
            lbl_TongVon.Text = TongVon.ToString();
            int TongThu = 0;
            for (int i = 0; i < gridView2.DataRowCount; i++)
            {
                DataRowView selectedRow = (DataRowView)gridView2.GetRow(i);
                int Tien;
                try
                {
                    Tien = int.Parse(selectedRow.Row.ItemArray[3].ToString());
                }
                catch
                {
                    Tien = 0;
                }
                TongThu += Tien;
            }
            lbl_TongThu.Text = TongThu.ToString();
            lbl_ThuNhap.Text = (TongThu - TongVon).ToString();
        }

        private void cbb_LoaiThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideAll();
            if (cbb_LoaiThongKe.SelectedIndex == 0)
            {

                ngay.Visible = true;
                thang.Visible = true;
                nam.Visible = true;
                txtNgay.Visible = true;
                txtThang.Visible = true;
                txtNam.Visible = true;

                BindingSource bs = new BindingSource();

                bs.DataSource = dn.Get_ThongKeTheoNam(nam.Text, thang.Text, ngay.Text).Tables["DONNHAP"];
                grid_DonNhap.DataSource = bs;

                BindingSource _bs = new BindingSource();

                _bs.DataSource = db.Get_ThongKeTheoNam(nam.Text, thang.Text, ngay.Text, "", false).Tables["DONBAN"];
                grid_baoCaoBanHang.DataSource = _bs;

            }
            if (cbb_LoaiThongKe.SelectedIndex == 1)
            {

                thang.Visible = true;
                nam.Visible = true;
                txtThang.Visible = true;
                txtNam.Visible = true;
                BindingSource bs = new BindingSource();

                bs.DataSource = dn.Get_ThongKeTheoNam(nam.Text, thang.Text, "0").Tables["DONNHAP"];
                grid_DonNhap.DataSource = bs;
                BindingSource _bs = new BindingSource();

                _bs.DataSource = db.Get_ThongKeTheoNam(nam.Text, thang.Text, "0", "", false).Tables["DONBAN"];
                grid_baoCaoBanHang.DataSource = _bs;
            }

            if (cbb_LoaiThongKe.SelectedIndex == 2)
            {
                nam.Visible = true;
                txtNam.Visible = true;
                BindingSource bs = new BindingSource();

                bs.DataSource = dn.Get_ThongKeTheoNam(nam.Text, "0", "0").Tables["DONNHAP"];
                grid_DonNhap.DataSource = bs;

                BindingSource _bs = new BindingSource();

                _bs.DataSource = db.Get_ThongKeTheoNam(nam.Text, "0", "0", "", false).Tables["DONBAN"];
                grid_baoCaoBanHang.DataSource = _bs;
            }
            if (cbb_LoaiThongKe.SelectedIndex == 3)
            {
                ngay.Visible = true;
                thang.Visible = true;
                nam.Visible = true;
                txtNgay.Visible = true;
                txtThang.Visible = true;
                txtNam.Visible = true;
                ngay_2.Visible = true;
                thang_2.Visible = true;
                nam_2.Visible = true;
                txtNgay2.Visible = true;
                txtThang2.Visible = true;
                txtNam2.Visible = true;
                BindingSource bs = new BindingSource();

                bs.DataSource = dn.Get_ThongKeKhoangTime(nam.Text, thang.Text, ngay.Text, nam_2.Text, thang_2.Text, ngay_2.Text).Tables["DONNHAP"];
                grid_DonNhap.DataSource = bs;
                BindingSource _bs = new BindingSource();

                _bs.DataSource = db.Get_ThongKeKhoangTime(nam.Text, thang.Text, ngay.Text, "", nam_2.Text, thang_2.Text, ngay_2.Text,false).Tables["DONBAN"];
                grid_baoCaoBanHang.DataSource = _bs;
            }
            TinhTongGia();
        }

        private void ngay_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_LoaiThongKe_SelectedIndexChanged(null, null);
        }

        private void thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_LoaiThongKe_SelectedIndexChanged(null, null);
        }

        private void nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_LoaiThongKe_SelectedIndexChanged(null, null);
        }

        private void ngay_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_LoaiThongKe_SelectedIndexChanged(null, null);
        }

        private void thang_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_LoaiThongKe_SelectedIndexChanged(null, null);
        }

        private void nam_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_LoaiThongKe_SelectedIndexChanged(null, null);
        }
    }
}
