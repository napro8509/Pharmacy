namespace PharmacyManager
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_taikhoan.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taikhoan.Location = new System.Drawing.Point(183, 99);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(237, 32);
            this.txt_taikhoan.TabIndex = 0;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_matkhau.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.Location = new System.Drawing.Point(183, 181);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(237, 32);
            this.txt_matkhau.TabIndex = 1;
            this.txt_matkhau.UseSystemPasswordChar = true;
            this.txt_matkhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_matkhau_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(183, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 19);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Tài Khoản";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(183, 146);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 19);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "Mật Khẩu";
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_CapNhat.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_CapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_CapNhat.Appearance.Options.UseBackColor = true;
            this.btn_CapNhat.Appearance.Options.UseFont = true;
            this.btn_CapNhat.Appearance.Options.UseForeColor = true;
            this.btn_CapNhat.Appearance.Options.UseTextOptions = true;
            this.btn_CapNhat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_CapNhat.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_CapNhat.AppearanceHovered.Options.UseBackColor = true;
            this.btn_CapNhat.ImageOptions.Image = global::PharmacyManager.Properties.Resources.icon_check;
            this.btn_CapNhat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_CapNhat.Location = new System.Drawing.Point(114, 260);
            this.btn_CapNhat.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btn_CapNhat.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(169, 90);
            this.btn_CapNhat.TabIndex = 94;
            this.btn_CapNhat.Text = "ĐĂNG NHẬP";
            this.btn_CapNhat.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHuy.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Appearance.Options.UseBackColor = true;
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Appearance.Options.UseForeColor = true;
            this.btnHuy.Appearance.Options.UseTextOptions = true;
            this.btnHuy.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnHuy.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHuy.AppearanceHovered.Options.UseBackColor = true;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(308, 260);
            this.btnHuy.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnHuy.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(169, 90);
            this.btnHuy.TabIndex = 95;
            this.btnHuy.Text = "THOÁT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(168, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 25);
            this.label1.TabIndex = 96;
            this.label1.Text = "ĐĂNG NHẬP VÀO HỆ THỐNG";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(588, 391);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_taikhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.TextBox txt_matkhau;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_CapNhat;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private System.Windows.Forms.Label label1;
    }
}