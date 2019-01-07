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
    public partial class SoLuongThuocBan : UserControl
    {
        BUS_DonBan db = new BUS_DonBan();
        DateTime now = DateTime.Now;
        public SoLuongThuocBan()
        {
            InitializeComponent();
        }

        private void grid_SLThuocBan_Load(object sender, EventArgs e)
        {
            //BindingSource bs = new BindingSource();
            //bs.DataSource = db.Get_ThongKeSoLuongThuoc("0","0","0").Tables["CTDONTHUOC,THUOC"];
            //grid_SLThuocBan.DataSource = bs;
        }
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
            ngay_2.Visible = false;
            thang_2.Visible = false;
            nam_2.Visible = false;
            txtNgay1.Visible = false;
            txtThang1.Visible = false;
            txtNam1.Visible = false;
            txtNgay2.Visible = false;
            txtThang2.Visible = false;
            txtNam2.Visible = false;
        }
        private void cbb_LoaiThongKe_BindingContextChanged(object sender, EventArgs e)
        {
            //HideAll();
            //if (cbb_LoaiThongKe.SelectedIndex == 0)
            //{

            //    ngay.Visible = true;
            //    thang.Visible = true;
            //    nam.Visible = true;
            //    txtNgay1.Visible = true;
            //    txtThang1.Visible = true;
            //    txtNam1.Visible = true;
            //    BindingSource bs = new BindingSource();

            //    bs.DataSource = db.Get_ThongKeSoLuongThuoc(nam.Text, thang.Text, ngay.Text).Tables["CTDONTHUOC,THUOC"];
            //    grid_SLThuocBan.DataSource = bs;
            //}
            //if (cbb_LoaiThongKe.SelectedIndex == 1)
            //{

            //    thang.Visible = true;
            //    nam.Visible = true;
            //    txtThang1.Visible = true;
            //    txtNam1.Visible = true;
            //    BindingSource bs = new BindingSource();

            //    bs.DataSource = db.Get_ThongKeSoLuongThuoc(nam.Text, thang.Text, "0").Tables["CTDONTHUOC,THUOC"];
            //    grid_SLThuocBan.DataSource = bs;
            //}

            //if (cbb_LoaiThongKe.SelectedIndex == 2)
            //{
            //    nam.Visible = true;
            //    txtNam1.Visible = true;
            //    BindingSource bs = new BindingSource();

            //    bs.DataSource = db.Get_ThongKeSoLuongThuoc(nam.Text, "0", "0").Tables["CTDONTHUOC,THUOC"];
            //    grid_SLThuocBan.DataSource = bs;
            //}
            //if (cbb_LoaiThongKe.SelectedIndex == 3)
            //{
            //    ngay.Visible = true;
            //    thang.Visible = true;
            //    nam.Visible = true;
            //    ngay_2.Visible = true;
            //    thang_2.Visible = true;
            //    nam_2.Visible = true;
            //    txtNgay1.Visible = true;
            //    txtThang1.Visible = true;
            //    txtNam1.Visible = true;
            //    txtNgay2.Visible = true;
            //    txtThang2.Visible = true;
            //    txtNam2.Visible = true;
            //    BindingSource bs = new BindingSource();
            //    //db.Get_ThongKeKhoangTime(nam.Text, thang.Text, ngay.Text, MaDuocSy, nam_2.Text, thang_2.Text, ngay_2.Text);

            //    //bs.DataSource = db.Get_ThongKeKhoangTime(nam.Text, thang.Text, ngay.Text, MaDuocSy, nam_2.Text, thang_2.Text, ngay_2.Text).Tables["DONBAN"];
            //    grid_SLThuocBan.DataSource = bs;
            //}
        }

        private void SoLuongThuocBan_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            addItem();
            //cbb_DuocSy.SelectedIndex = 0;
            ngay.SelectedIndex = now.Day - 1;
            thang.SelectedIndex = now.Month - 1;
            nam.SelectedIndex = now.Year - 2000;
            ngay_2.SelectedIndex = now.Day - 1;
            thang_2.SelectedIndex = now.Month - 1;
            nam_2.SelectedIndex = now.Year - 2000;
            cbb_LoaiThongKe.SelectedIndex = 0;
        }

        private void cbb_LoaiThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideAll();
            if (cbb_LoaiThongKe.SelectedIndex == 0)
            {

                ngay.Visible = true;
                thang.Visible = true;
                nam.Visible = true;
                txtNgay1.Visible = true;
                txtThang1.Visible = true;
                txtNam1.Visible = true;
                BindingSource bs = new BindingSource();

                bs.DataSource = db.Get_ThongKeSoLuongThuoc(nam.Text, thang.Text, ngay.Text).Tables["CTDONTHUOC,THUOC"];
                grid_SLThuocBan.DataSource = bs;
            }
            if (cbb_LoaiThongKe.SelectedIndex == 1)
            {

                thang.Visible = true;
                nam.Visible = true;
                txtThang1.Visible = true;
                txtNam1.Visible = true;
                BindingSource bs = new BindingSource();

                bs.DataSource = db.Get_ThongKeSoLuongThuoc(nam.Text, thang.Text, "0").Tables["CTDONTHUOC,THUOC"];
                grid_SLThuocBan.DataSource = bs;
            }

            if (cbb_LoaiThongKe.SelectedIndex == 2)
            {
                nam.Visible = true;
                txtNam1.Visible = true;
                BindingSource bs = new BindingSource();

                bs.DataSource = db.Get_ThongKeSoLuongThuoc(nam.Text, "0", "0").Tables["CTDONTHUOC,THUOC"];
                grid_SLThuocBan.DataSource = bs;
            }
            if (cbb_LoaiThongKe.SelectedIndex == 3)
            {
                ngay.Visible = true;
                thang.Visible = true;
                nam.Visible = true;
                ngay_2.Visible = true;
                thang_2.Visible = true;
                nam_2.Visible = true;
                txtNgay1.Visible = true;
                txtThang1.Visible = true;
                txtNam1.Visible = true;
                txtNgay2.Visible = true;
                txtThang2.Visible = true;
                txtNam2.Visible = true;
                BindingSource bs = new BindingSource();
                //db.Get_ThongKeKhoangTime(nam.Text, thang.Text, ngay.Text, MaDuocSy, nam_2.Text, thang_2.Text, ngay_2.Text);

                bs.DataSource = db.Get_SoLuongKhoangTime(nam.Text, thang.Text, ngay.Text, nam_2.Text, thang_2.Text, ngay_2.Text).Tables["CTDONTHUOC,THUOC"];
                grid_SLThuocBan.DataSource = bs;
            }
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
