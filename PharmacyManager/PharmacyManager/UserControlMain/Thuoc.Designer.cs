namespace PharmacyManager.UserControlMain
{
    partial class Thuoc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thuoc));
            this.sl = new System.Windows.Forms.TextBox();
            this.lbl_giasauthue = new System.Windows.Forms.Label();
            this.stt = new System.Windows.Forms.Label();
            this.tenthuoc = new System.Windows.Forms.Label();
            this.tongtien = new System.Windows.Forms.TextBox();
            this.loaisl = new System.Windows.Forms.ComboBox();
            this.lbl_masanpham = new System.Windows.Forms.Label();
            this.ngay = new System.Windows.Forms.ComboBox();
            this.thang = new System.Windows.Forms.ComboBox();
            this.nam = new System.Windows.Forms.ComboBox();
            this.btn_less = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_more = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // sl
            // 
            this.sl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sl.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sl.ForeColor = System.Drawing.Color.Black;
            this.sl.Location = new System.Drawing.Point(453, 2);
            this.sl.Name = "sl";
            this.sl.Size = new System.Drawing.Size(69, 30);
            this.sl.TabIndex = 4;
            this.sl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sl_KeyPress);
            this.sl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.sl_KeyUp);
            // 
            // lbl_giasauthue
            // 
            this.lbl_giasauthue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_giasauthue.AutoSize = true;
            this.lbl_giasauthue.BackColor = System.Drawing.Color.White;
            this.lbl_giasauthue.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_giasauthue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_giasauthue.Location = new System.Drawing.Point(315, 6);
            this.lbl_giasauthue.Name = "lbl_giasauthue";
            this.lbl_giasauthue.Size = new System.Drawing.Size(54, 22);
            this.lbl_giasauthue.TabIndex = 5;
            this.lbl_giasauthue.Text = "6000";
            // 
            // stt
            // 
            this.stt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stt.AutoSize = true;
            this.stt.BackColor = System.Drawing.Color.White;
            this.stt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.stt.Location = new System.Drawing.Point(19, 6);
            this.stt.Name = "stt";
            this.stt.Size = new System.Drawing.Size(21, 22);
            this.stt.TabIndex = 7;
            this.stt.Text = "1";
            // 
            // tenthuoc
            // 
            this.tenthuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tenthuoc.AutoSize = true;
            this.tenthuoc.BackColor = System.Drawing.Color.White;
            this.tenthuoc.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenthuoc.ForeColor = System.Drawing.Color.Black;
            this.tenthuoc.Location = new System.Drawing.Point(170, 6);
            this.tenthuoc.Name = "tenthuoc";
            this.tenthuoc.Size = new System.Drawing.Size(59, 22);
            this.tenthuoc.TabIndex = 8;
            this.tenthuoc.Text = "label3";
            // 
            // tongtien
            // 
            this.tongtien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tongtien.BackColor = System.Drawing.Color.White;
            this.tongtien.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongtien.ForeColor = System.Drawing.Color.Black;
            this.tongtien.Location = new System.Drawing.Point(631, 2);
            this.tongtien.Name = "tongtien";
            this.tongtien.ReadOnly = true;
            this.tongtien.Size = new System.Drawing.Size(71, 30);
            this.tongtien.TabIndex = 6;
            // 
            // loaisl
            // 
            this.loaisl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loaisl.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loaisl.FormattingEnabled = true;
            this.loaisl.Location = new System.Drawing.Point(561, 2);
            this.loaisl.Name = "loaisl";
            this.loaisl.Size = new System.Drawing.Size(58, 30);
            this.loaisl.TabIndex = 10;
            this.loaisl.SelectedIndexChanged += new System.EventHandler(this.loaisl_SelectedIndexChanged);
            // 
            // lbl_masanpham
            // 
            this.lbl_masanpham.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_masanpham.AutoSize = true;
            this.lbl_masanpham.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_masanpham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_masanpham.Location = new System.Drawing.Point(79, 6);
            this.lbl_masanpham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_masanpham.Name = "lbl_masanpham";
            this.lbl_masanpham.Size = new System.Drawing.Size(59, 22);
            this.lbl_masanpham.TabIndex = 11;
            this.lbl_masanpham.Text = "label1";
            // 
            // ngay
            // 
            this.ngay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ngay.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngay.FormattingEnabled = true;
            this.ngay.Location = new System.Drawing.Point(716, 2);
            this.ngay.Name = "ngay";
            this.ngay.Size = new System.Drawing.Size(36, 30);
            this.ngay.TabIndex = 12;
            // 
            // thang
            // 
            this.thang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.thang.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thang.FormattingEnabled = true;
            this.thang.Location = new System.Drawing.Point(758, 2);
            this.thang.Name = "thang";
            this.thang.Size = new System.Drawing.Size(36, 30);
            this.thang.TabIndex = 13;
            // 
            // nam
            // 
            this.nam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nam.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nam.FormattingEnabled = true;
            this.nam.Location = new System.Drawing.Point(800, 2);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(76, 30);
            this.nam.TabIndex = 14;
            this.nam.SelectedIndexChanged += new System.EventHandler(this.nam_SelectedIndexChanged);
            // 
            // btn_less
            // 
            this.btn_less.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_less.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_less.ImageOptions.Image = global::PharmacyManager.Properties.Resources.icon_add;
            this.btn_less.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_less.Location = new System.Drawing.Point(415, 0);
            this.btn_less.Name = "btn_less";
            this.btn_less.Size = new System.Drawing.Size(32, 32);
            this.btn_less.TabIndex = 17;
            this.btn_less.Click += new System.EventHandler(this.btn_less_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_xoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.ImageOptions.Image")));
            this.btn_xoa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_xoa.Location = new System.Drawing.Point(900, 0);
            this.btn_xoa.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(32, 32);
            this.btn_xoa.TabIndex = 16;
            this.btn_xoa.Text = "\r\n";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_more
            // 
            this.btn_more.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_more.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_more.ImageOptions.Image = global::PharmacyManager.Properties.Resources.icon_minus;
            this.btn_more.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_more.Location = new System.Drawing.Point(528, 0);
            this.btn_more.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_more.Name = "btn_more";
            this.btn_more.Size = new System.Drawing.Size(32, 32);
            this.btn_more.TabIndex = 16;
            this.btn_more.Text = "\r\n";
            this.btn_more.Click += new System.EventHandler(this.btn_more_Click);
            // 
            // Thuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_less);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_more);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.thang);
            this.Controls.Add(this.ngay);
            this.Controls.Add(this.lbl_masanpham);
            this.Controls.Add(this.loaisl);
            this.Controls.Add(this.tenthuoc);
            this.Controls.Add(this.stt);
            this.Controls.Add(this.tongtien);
            this.Controls.Add(this.lbl_giasauthue);
            this.Controls.Add(this.sl);
            this.Name = "Thuoc";
            this.Size = new System.Drawing.Size(952, 36);
            this.Load += new System.EventHandler(this.Thuoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox sl;
        private System.Windows.Forms.Label lbl_giasauthue;
        private System.Windows.Forms.Label stt;
        private System.Windows.Forms.Label tenthuoc;
        private System.Windows.Forms.TextBox tongtien;
        private System.Windows.Forms.ComboBox loaisl;
        private System.Windows.Forms.Label lbl_masanpham;
        private System.Windows.Forms.ComboBox ngay;
        private System.Windows.Forms.ComboBox thang;
        private System.Windows.Forms.ComboBox nam;
        private DevExpress.XtraEditors.SimpleButton btn_more;
        private DevExpress.XtraEditors.SimpleButton btn_xoa;
        private DevExpress.XtraEditors.SimpleButton btn_less;
    }
}
