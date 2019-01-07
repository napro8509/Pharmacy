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
    public partial class NhaCungCap : UserControl
    {
        BUS_NhaCungCap ncc = new BUS_NhaCungCap();

        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            ncc.Get_CONGTY();
            bs.DataSource = ncc.Get_CONGTY().Tables["CONGTY"];
            gridControl1.DataSource = bs;
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Them_NhaCungCap ncc = new Them_NhaCungCap();
            ncc.ShowDialog();
            gridControl1_Load(null, null);
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)gridView1.GetRow(gridView1.FocusedRowHandle);
            string MaNhaCC = selectedRow.Row.ItemArray[0].ToString();
            string TenNhaCC = selectedRow.Row.ItemArray[1].ToString();
            string DiaChi = selectedRow.Row.ItemArray[2].ToString();
            Them_NhaCungCap ncc = new Them_NhaCungCap(MaNhaCC,TenNhaCC,DiaChi);
            ncc.ShowDialog();
            gridControl1_Load(null, null);
        }

        

       

       
        
    }
}
