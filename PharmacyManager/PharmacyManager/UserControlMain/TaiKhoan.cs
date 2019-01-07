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
    public partial class TaiKhoan : UserControl
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }
        DateTime now = DateTime.Now;
        BUS_TaiKhoan tk = new BUS_TaiKhoan();
        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            //rdb_dpBanThuoc.Checked = true;
            //rdb_dpNhapThuoc.Checked = true;
            //rdb_dpTaiKhoan.Checked = true;
            //rdb_dpThongKe.Checked = true;
            //addItem();
            //ngay.SelectedIndex = now.Day - 1;
            //thang.SelectedIndex = now.Month - 1;
            //nam.SelectedIndex = now.Year - 2000;
            this.Dock = DockStyle.Fill;
        }


        private void btn_TaoTaiKhoan_Click(object sender, EventArgs e)
        {
            //string MaDuocSy = txt_MaDuocSy.Text;
            //string TenDuocSy = txt_TenDuocSy.Text;
            //string TaiKhoan = txt_TaiKhoan.Text;
            //string MatKhau = txt_MatKhau.Text;
            //string BangCap = cbb_BangCap.Text;
            //int Luong = int.Parse(txt_luong.Text);
            //string NgayVaoLam = thang.Text + "/" + ngay.Text + "/" + nam.Text;
            //int dpBanThuoc = 0;
            //int dpNhapKho = 0;
            //int dpThongKe = 0;
            //int dpTaoTaiKhoan = 0;
            //if (rdb_dpBanThuoc.Checked == true)
            //    dpBanThuoc = 1;
            //if (rdb_dpNhapThuoc.Checked == true)
            //    dpNhapKho = 1;
            //if (rdb_dpThongKe.Checked == true)
            //    dpThongKe = 1;
            //if (rdb_dpTaiKhoan.Checked == true)
            //    dpTaoTaiKhoan = 1;
            //if (txt_MaDuocSy.Enabled == false)
            //{
            //    tk.CapNhatDuocSy(MaDuocSy, TenDuocSy, BangCap, NgayVaoLam, Luong);
            //    tk.CapNhatTaiKhoan(TaiKhoan, MatKhau, MaDuocSy);
            //    tk.CapNhatQuyen(TaiKhoan, dpBanThuoc, dpNhapKho, dpThongKe, dpTaoTaiKhoan);
            //}
            //else
            //{
            //    tk.TaoDuocSy(MaDuocSy, TenDuocSy, BangCap, NgayVaoLam, Luong);
            //    tk.NhapTaiKhoanMoi(TaiKhoan, MatKhau, MaDuocSy);
            //    tk.TaoQuyen(TaiKhoan, dpBanThuoc, dpNhapKho, dpThongKe, dpTaoTaiKhoan);
            //}
            //grid_DSTaiKhoan_Load(null, null);
        }

        private void grid_DSTaiKhoan_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = tk.DSTaiKhoan().Tables["DUOCSY,TAIKHOAN,QUYEN"];
            grid_DSTaiKhoan.DataSource = bs;
        }

        private void btn_CapNhatTaiKhoan_Click(object sender, EventArgs e)
        {
            
            DataRowView selectedRow = (DataRowView)gridView1.GetRow(gridView1.FocusedRowHandle);
            string MaDuocSy = selectedRow.Row.ItemArray[0].ToString();
            string TenDuocSy = selectedRow.Row.ItemArray[1].ToString();
            string TaiKhoan = selectedRow.Row.ItemArray[5].ToString();
            int Luong = int.Parse(selectedRow.Row.ItemArray[4].ToString());
            string NgayVaoLam = selectedRow.Row.ItemArray[3].ToString();
            string BangCap = selectedRow.Row.ItemArray[2].ToString();
            string MatKhau = selectedRow.Row.ItemArray[6].ToString();
            int dpBanThuoc=int.Parse(selectedRow.Row.ItemArray[9].ToString());
            int dpNhapThuoc=int.Parse(selectedRow.Row.ItemArray[10].ToString());
            int dpThongKe=int.Parse(selectedRow.Row.ItemArray[11].ToString());
            int dpTaoTaiKhoan = int.Parse(selectedRow.Row.ItemArray[12].ToString());
            ThemTaiKhoan formNhapThuoc = new ThemTaiKhoan(MaDuocSy, TenDuocSy, TaiKhoan, MatKhau, BangCap, Luong, NgayVaoLam, dpBanThuoc, dpNhapThuoc, dpThongKe, dpTaoTaiKhoan);
            formNhapThuoc.ShowDialog();
            grid_DSTaiKhoan_Load(null, null);
        }
        //void SetNVL(string ipntn)
        //{
        //    string[] tokens = ipntn.Split('/');
        //    int a = int.Parse(tokens[1]) - 1;
        //    ngay.SelectedIndex = a;
        //    a = int.Parse(tokens[0]) - 1;
        //    thang.SelectedIndex = a;
        //    string[] tokens_2 = tokens[2].Split(' ');
        //    a = int.Parse(tokens_2[0]) - 2000;
        //    nam.SelectedIndex = a;
        //}
        //int SetBangCap(string BangCap)
        //{
        //    for (int i = 0; i < cbb_BangCap.Items.Count; i++)
        //    {
        //        cbb_BangCap.SelectedIndex = i;
        //        if (cbb_BangCap.Text == BangCap)
        //            return i;

        //    }
        //    return 0;
        //}

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan formNhapThuoc = new ThemTaiKhoan();
            formNhapThuoc.ShowDialog();
            grid_DSTaiKhoan_Load(null, null);
        }
    }
}
