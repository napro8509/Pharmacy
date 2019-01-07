namespace PharmacyManager.UserControlMain
{
    partial class SoLuongThuocBan
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
            this.grid_SLThuocBan = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtNam2 = new DevExpress.XtraEditors.LabelControl();
            this.txtThang2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNam1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNgay2 = new DevExpress.XtraEditors.LabelControl();
            this.txtThang1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNgay1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.nam_2 = new System.Windows.Forms.ComboBox();
            this.thang_2 = new System.Windows.Forms.ComboBox();
            this.ngay_2 = new System.Windows.Forms.ComboBox();
            this.cbb_LoaiThongKe = new System.Windows.Forms.ComboBox();
            this.ngay = new System.Windows.Forms.ComboBox();
            this.thang = new System.Windows.Forms.ComboBox();
            this.nam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SLThuocBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_SLThuocBan
            // 
            this.grid_SLThuocBan.Location = new System.Drawing.Point(152, 181);
            this.grid_SLThuocBan.MainView = this.gridView1;
            this.grid_SLThuocBan.Name = "grid_SLThuocBan";
            this.grid_SLThuocBan.Size = new System.Drawing.Size(573, 252);
            this.grid_SLThuocBan.TabIndex = 0;
            this.grid_SLThuocBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grid_SLThuocBan.Load += new System.EventHandler(this.grid_SLThuocBan_Load);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grid_SLThuocBan;
            this.gridView1.Name = "gridView1";
            // 
            // txtNam2
            // 
            this.txtNam2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNam2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtNam2.Appearance.Options.UseFont = true;
            this.txtNam2.Appearance.Options.UseForeColor = true;
            this.txtNam2.Location = new System.Drawing.Point(834, 46);
            this.txtNam2.Name = "txtNam2";
            this.txtNam2.Size = new System.Drawing.Size(33, 19);
            this.txtNam2.TabIndex = 34;
            this.txtNam2.Text = "Năm";
            // 
            // txtThang2
            // 
            this.txtThang2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtThang2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtThang2.Appearance.Options.UseFont = true;
            this.txtThang2.Appearance.Options.UseForeColor = true;
            this.txtThang2.Location = new System.Drawing.Point(762, 46);
            this.txtThang2.Name = "txtThang2";
            this.txtThang2.Size = new System.Drawing.Size(45, 19);
            this.txtThang2.TabIndex = 35;
            this.txtThang2.Text = "Tháng";
            // 
            // txtNam1
            // 
            this.txtNam1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNam1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtNam1.Appearance.Options.UseFont = true;
            this.txtNam1.Appearance.Options.UseForeColor = true;
            this.txtNam1.Location = new System.Drawing.Point(605, 46);
            this.txtNam1.Name = "txtNam1";
            this.txtNam1.Size = new System.Drawing.Size(33, 19);
            this.txtNam1.TabIndex = 36;
            this.txtNam1.Text = "Năm";
            // 
            // txtNgay2
            // 
            this.txtNgay2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNgay2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtNgay2.Appearance.Options.UseFont = true;
            this.txtNgay2.Appearance.Options.UseForeColor = true;
            this.txtNgay2.Location = new System.Drawing.Point(694, 46);
            this.txtNgay2.Name = "txtNgay2";
            this.txtNgay2.Size = new System.Drawing.Size(36, 19);
            this.txtNgay2.TabIndex = 37;
            this.txtNgay2.Text = "Ngày";
            // 
            // txtThang1
            // 
            this.txtThang1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtThang1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtThang1.Appearance.Options.UseFont = true;
            this.txtThang1.Appearance.Options.UseForeColor = true;
            this.txtThang1.Location = new System.Drawing.Point(533, 46);
            this.txtThang1.Name = "txtThang1";
            this.txtThang1.Size = new System.Drawing.Size(45, 19);
            this.txtThang1.TabIndex = 38;
            this.txtThang1.Text = "Tháng";
            // 
            // txtNgay1
            // 
            this.txtNgay1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNgay1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtNgay1.Appearance.Options.UseFont = true;
            this.txtNgay1.Appearance.Options.UseForeColor = true;
            this.txtNgay1.Location = new System.Drawing.Point(465, 46);
            this.txtNgay1.Name = "txtNgay1";
            this.txtNgay1.Size = new System.Drawing.Size(36, 19);
            this.txtNgay1.TabIndex = 39;
            this.txtNgay1.Text = "Ngày";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(68, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(138, 19);
            this.labelControl2.TabIndex = 41;
            this.labelControl2.Text = "Chọn Điều Kiện Lọc";
            // 
            // nam_2
            // 
            this.nam_2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nam_2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nam_2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.nam_2.FormattingEnabled = true;
            this.nam_2.Location = new System.Drawing.Point(820, 71);
            this.nam_2.Name = "nam_2";
            this.nam_2.Size = new System.Drawing.Size(79, 30);
            this.nam_2.TabIndex = 32;
            this.nam_2.SelectedIndexChanged += new System.EventHandler(this.nam_2_SelectedIndexChanged);
            // 
            // thang_2
            // 
            this.thang_2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.thang_2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thang_2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.thang_2.FormattingEnabled = true;
            this.thang_2.Location = new System.Drawing.Point(751, 71);
            this.thang_2.Name = "thang_2";
            this.thang_2.Size = new System.Drawing.Size(63, 30);
            this.thang_2.TabIndex = 31;
            this.thang_2.SelectedIndexChanged += new System.EventHandler(this.thang_2_SelectedIndexChanged);
            // 
            // ngay_2
            // 
            this.ngay_2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ngay_2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngay_2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ngay_2.FormattingEnabled = true;
            this.ngay_2.Location = new System.Drawing.Point(687, 71);
            this.ngay_2.Name = "ngay_2";
            this.ngay_2.Size = new System.Drawing.Size(58, 30);
            this.ngay_2.TabIndex = 30;
            this.ngay_2.SelectedIndexChanged += new System.EventHandler(this.ngay_2_SelectedIndexChanged);
            // 
            // cbb_LoaiThongKe
            // 
            this.cbb_LoaiThongKe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbb_LoaiThongKe.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_LoaiThongKe.FormattingEnabled = true;
            this.cbb_LoaiThongKe.Items.AddRange(new object[] {
            "Báo Cáo Theo Ngày",
            "Báo Cáo Theo Tháng",
            "Báo Cáo Theo Năm",
            "Bao Cáo Theo Khoảng Thời Gian"});
            this.cbb_LoaiThongKe.Location = new System.Drawing.Point(68, 71);
            this.cbb_LoaiThongKe.Name = "cbb_LoaiThongKe";
            this.cbb_LoaiThongKe.Size = new System.Drawing.Size(212, 30);
            this.cbb_LoaiThongKe.TabIndex = 26;
            this.cbb_LoaiThongKe.SelectedIndexChanged += new System.EventHandler(this.cbb_LoaiThongKe_SelectedIndexChanged);
            this.cbb_LoaiThongKe.BindingContextChanged += new System.EventHandler(this.cbb_LoaiThongKe_BindingContextChanged);
            // 
            // ngay
            // 
            this.ngay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ngay.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngay.FormattingEnabled = true;
            this.ngay.Location = new System.Drawing.Point(454, 71);
            this.ngay.Name = "ngay";
            this.ngay.Size = new System.Drawing.Size(62, 30);
            this.ngay.TabIndex = 27;
            this.ngay.SelectedIndexChanged += new System.EventHandler(this.ngay_SelectedIndexChanged);
            // 
            // thang
            // 
            this.thang.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.thang.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thang.FormattingEnabled = true;
            this.thang.Location = new System.Drawing.Point(522, 71);
            this.thang.Name = "thang";
            this.thang.Size = new System.Drawing.Size(62, 30);
            this.thang.TabIndex = 28;
            this.thang.SelectedIndexChanged += new System.EventHandler(this.thang_SelectedIndexChanged);
            // 
            // nam
            // 
            this.nam.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nam.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nam.FormattingEnabled = true;
            this.nam.Location = new System.Drawing.Point(594, 71);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(80, 30);
            this.nam.TabIndex = 29;
            this.nam.SelectedIndexChanged += new System.EventHandler(this.nam_SelectedIndexChanged);
            // 
            // SoLuongThuocBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNam2);
            this.Controls.Add(this.txtThang2);
            this.Controls.Add(this.txtNam1);
            this.Controls.Add(this.txtNgay2);
            this.Controls.Add(this.txtThang1);
            this.Controls.Add(this.txtNgay1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.nam_2);
            this.Controls.Add(this.thang_2);
            this.Controls.Add(this.ngay_2);
            this.Controls.Add(this.cbb_LoaiThongKe);
            this.Controls.Add(this.ngay);
            this.Controls.Add(this.thang);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.grid_SLThuocBan);
            this.Name = "SoLuongThuocBan";
            this.Size = new System.Drawing.Size(966, 487);
            this.Load += new System.EventHandler(this.SoLuongThuocBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_SLThuocBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid_SLThuocBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl txtNam2;
        private DevExpress.XtraEditors.LabelControl txtThang2;
        private DevExpress.XtraEditors.LabelControl txtNam1;
        private DevExpress.XtraEditors.LabelControl txtNgay2;
        private DevExpress.XtraEditors.LabelControl txtThang1;
        private DevExpress.XtraEditors.LabelControl txtNgay1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox nam_2;
        private System.Windows.Forms.ComboBox thang_2;
        private System.Windows.Forms.ComboBox ngay_2;
        private System.Windows.Forms.ComboBox cbb_LoaiThongKe;
        private System.Windows.Forms.ComboBox ngay;
        private System.Windows.Forms.ComboBox thang;
        private System.Windows.Forms.ComboBox nam;
    }
}
