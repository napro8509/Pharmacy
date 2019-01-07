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
using BUS;
namespace PharmacyManager
{
    public partial class CapNhatTaiKhoan : Form
    {
        BUS_TaiKhoan tk = new BUS_TaiKhoan();
        string MaDuocSy;
        public CapNhatTaiKhoan(string maDS)
        {
            InitializeComponent();
            MaDuocSy = maDS;
        }

        private void CapNhatTaiKhoan_Load(object sender, EventArgs e)
        {
            UserControlMain.CapNhatTaiKhoan updateAccount = new UserControlMain.CapNhatTaiKhoan(MaDuocSy);
            this.Controls.Add(updateAccount);
        }
    }
}
