using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace PharmacyManager
{
    public partial class Login : Form
    {
        BUS_TaiKhoan tk = new BUS_TaiKhoan();
        public Login()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txt_taikhoan.Text;
            string name = tk.Get_TenDuocSy(username);
            string t = tk.Get_MatKhau(username);
            
            if (txt_matkhau.Text == t)
            {
                this.Hide();
                Form1 f1 = new Form1(username);
                f1.Show();
            }
        }

        private void txt_matkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
        }
    }
}
