using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PharmacyManager.UserControlMain
{
    public partial class Thuoc : UserControl
    {
        public Thuoc(int LoaiThuoc)
        {
            InitializeComponent();
            if (LoaiThuoc == 1)
            {
                loaisl.Items.Add("Viên");
                loaisl.Items.Add("Vỉ");
                loaisl.Items.Add("Hộp");
            }
            else
            {
                loaisl.Items.Add("Gói");
                loaisl.Items.Add("Hộp");
            }
        }
        
        public int gt=0;
        public int _stt;
        public int dv = 1;
        public int allsl = 0;
        public string ntn = "";
        DateTime now = DateTime.Now;
        private void Thuoc_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Top;
            sl.Text = "1";
            sl.TextAlign = HorizontalAlignment.Center;
            int tien = 0;
            int sl_ = 1;
            allsl = sl_;
            int tt=tien*allsl;
            tongtien.Text = tien.ToString();
            loaisl.SelectedIndex = 0;
            addItem();
            ngay.SelectedIndex = now.Day-1;
            thang.SelectedIndex = now.Month-1;
            nam.SelectedIndex = now.Year-2000;
            //DateTime now = DateTime.Now;
            addItem();

        }
        void addItem()
        {
            for (int i = 1; i <= 12; i++)
                thang.Items.Add(i);
            for (int i = 2000; i < now.Year+10; i++)
                nam.Items.Add(i);
            for (int i = 1; i <= 31; i++)
                ngay.Items.Add(i);
        }
        public void setSTT(int t)
        {
            stt.Text = t.ToString();
            _stt = t;
        }
        public int getSTT()
        {
            return _stt;
        }
        public string getMaSanPham()
        {
            return lbl_masanpham.Text;
        }
        public void setMaSanPham(string t)
        {
            lbl_masanpham.Text = t;
        }
        public string getName()
        {
            return tenthuoc.Text;
        }
        public void setTenThuoc(string t)
        {
            tenthuoc.Text = t;
        }
        public void setgt()
        {
            this.gt = 1;
        }
        public int getgt()
        {
            return gt;
        }
        public int getsl()
        {
            return int.Parse(sl.Text);
        }
        public int getTien()
        {
            int t = int.Parse(tongtien.Text);
            return t;
        }
        public void setGiaSauThue(string t)
        {
            lbl_giasauthue.Text = t;
        }
        public void setGiaNhap(string t)
        {
            //lbl_gianhap.Text = t;
        }
        public void setsl(int a)
        {
            sl.Text = a.ToString();
        }
        public void offbuttonless()
        {
            btn_less.Enabled = false;
        }
        public void onbuttonless()
        {
            btn_less.Enabled = true;
        }
        public void offbuttonmore()
        {
            btn_more.Enabled = false;
        }
        public void onbuttonmore()
        {
            btn_more.Enabled = true;
        }
        public void setsl()
        {
            this.btn_more_Click(null,null);
            
        }
        public void SetKieuSL(int size_sl)
        {
            loaisl.SelectedIndex = size_sl;
        }
        public void updateTongTien()
        {
            int sl_ = int.Parse(sl.Text.ToString());
            int tien = int.Parse(lbl_giasauthue.Text.ToString());
            int tt = tien * sl_;
            tongtien.Text = tt.ToString();
        }
        public int GetLoaiSL()
        {
            return loaisl.SelectedIndex;
        }
        public void SelectLoaiSL(bool a)
        {
            loaisl.Enabled = a;
        }
        public event EventHandler ButtonClick_more;

        private void btn_less_Click(object sender, EventArgs e)
        {
            int sl_ = int.Parse(sl.Text.ToString());
            sl_--;
            allsl = sl_ * dv;
            sl.Text = sl_.ToString();
            int tien = int.Parse(lbl_giasauthue.Text.ToString());
            int tt = tien * allsl;
            tongtien.Text = tt.ToString();
            if (this.ButtonClick_more != null)
                this.ButtonClick_more(this, e);
        }

        private void btn_more_Click(object sender, EventArgs e)
        {
            int sl_ = int.Parse(sl.Text.ToString());
            sl_++;
            allsl = sl_ * dv;
            sl.Text = sl_.ToString();
            int tien = int.Parse(lbl_giasauthue.Text.ToString());
            int tt = tien * allsl;
            tongtien.Text = tt.ToString();
            if (this.ButtonClick_more != null)
                this.ButtonClick_more(this, e);
        }
        public event EventHandler ButtonClick;

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            gt = 1;
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }
        //public event EventHandler ButtonChange_SL;
        private void sl_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int sl_ = int.Parse(sl.Text.ToString());
                allsl = sl_ * dv;
                int tien = int.Parse(lbl_giasauthue.Text.ToString());
                int tt = tien * allsl;
                tongtien.Text = tt.ToString();
                if (this.ButtonClick_more != null)
                    this.ButtonClick_more(this, e);
            }
            catch
            {

            }
        }
        
        private void loaisl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sl_ = int.Parse(sl.Text.ToString());
            int tien = int.Parse(lbl_giasauthue.Text.ToString());
            int tt = tien * sl_;
            tongtien.Text = tt.ToString();
            if (this.ButtonClick_more != null)
                this.ButtonClick_more(this, e);
        }

        private void sl_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled=true;
            }
        }

        private void nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            ntn = thang.Text + '/' + ngay.Text + '/' + nam.Text;
        }
        public void setNTN(string ipntn,int Can=0)
        {
            int _thang = 0;
            int _ngay = 1;
            if (ktraNgay()==false && Can==0)
            {
                _thang = 1;
                _ngay = 0;
            }
            string[] tokens = ipntn.Split('/');
            int a = int.Parse(tokens[_ngay]) - 1;
            ngay.SelectedIndex = a;
            a = int.Parse(tokens[_thang]) - 1;
            thang.SelectedIndex = a;
            string[] tokens_2 = tokens[2].Split(' ');
            a = int.Parse(tokens_2[0]) - 2000;
            nam.SelectedIndex = a;
        }
        public string setNTN(float _nam)
        {
            int nam_1 = (int)_nam;
            string t = _nam.ToString();
            float setthang;
            if ((float)nam_1 == _nam)
                setthang = 0;
            else
            {
                t = t.Remove(0, 2);
                setthang = float.Parse(t);
            }
            int thang_1 = (int)setthang;
            int th = thang.SelectedIndex + 1;
            int n;
            if (th + thang_1 > 12)
            {
                n = nam.SelectedIndex + 2000;
                n = n + nam_1 + 1;
            }
            else
            {
                n = nam.SelectedIndex + 2000;
                n = n + nam_1;
            }
            th = (th + thang_1) % 12;
            if (th == 0)
                th = 12;
            thang.SelectedIndex = th - 1;

            int year_now = nam.SelectedIndex;
            nam.SelectedIndex = n - 2000;
            string ntn = th.ToString() + "/" + ngay.Text + "/" + n.ToString();
            return ntn;
        }
        public string getNTN()
        {
            string ntn;
            if (ktraNgay())
                ntn = thang.Text + '/' + ngay.Text + '/' + nam.Text;
            else
                ntn = ngay.Text + '/' + thang.Text + '/' + nam.Text;
            return ntn;
        }
        bool ktraNgay()
        {
            DateTime now = DateTime.Today;
            string ngaythang = now.ToString();
            string[] tokens = ngaythang.Split(' ');
            ngaythang = tokens[0];
            string[] token_1 = ngaythang.Split('/');
            int ngay_1 = int.Parse(token_1[1]);
            int thang_1 = int.Parse(token_1[0]);
            int nam_2 = int.Parse(token_1[2]);
            if (thang_1 == now.Month && ngay_1 == now.Day)
                return true;
            return false;
        }
    }
}
