using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyManager.UserControlMain;
namespace PharmacyManager
{
    public partial class Them_NhaCungCap : Form
    {
        ThemNhaCungCap ncc = new ThemNhaCungCap();
        public Them_NhaCungCap()
        {
            InitializeComponent();
        }
        string MaNhaCC;
        string TenNhaCC;
        string DiaChi;
        bool NangCap = false;
        public Them_NhaCungCap(string MaNhaCC,string TenNhaCC,string DiaChi)
        {
            InitializeComponent();
            this.MaNhaCC = MaNhaCC;
            this.TenNhaCC = TenNhaCC;
            this.DiaChi = DiaChi;
            NangCap = true;
        }
        private void ThemNhaCungCap_Load(object sender, EventArgs e)
        {
            this.Controls.Add(ncc);
            if(NangCap==true)
                ncc.SetGT(MaNhaCC, TenNhaCC, DiaChi);

        }
    }
}
