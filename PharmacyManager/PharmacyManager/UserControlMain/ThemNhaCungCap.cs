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
    public partial class ThemNhaCungCap : UserControl
    {
        BUS_NhaCungCap ncc = new BUS_NhaCungCap();
        public ThemNhaCungCap()
        {
            InitializeComponent();
        }
        public void SetGT(string MaNhaCC, string TenNhaCC, string DiaChi)
        {
            txt_MaNhaCC.Text = MaNhaCC;
            txt_MaNhaCC.Enabled = false;
            txt_TenNhaCC.Text = TenNhaCC;
            txt_DiaChi.Text = DiaChi;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (txt_MaNhaCC.Enabled == false)
                ncc.CapNhatNhaCungCap(txt_MaNhaCC.Text, txt_TenNhaCC.Text, txt_DiaChi.Text);
            else
                ncc.ThemNhaCungCap(txt_MaNhaCC.Text, txt_TenNhaCC.Text, txt_DiaChi.Text);
            this.ParentForm.Close();
        }

        private void ThemNhaCungCap_Load(object sender, EventArgs e)
        {
            txt_MaNhaCC.Text = ncc.Get_TaoMaNhaCC();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
