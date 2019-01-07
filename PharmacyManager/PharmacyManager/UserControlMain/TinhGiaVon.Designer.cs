namespace PharmacyManager.UserControlMain
{
    partial class TinhGiaVon
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
            this.grid_DonNhap = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nam_2 = new System.Windows.Forms.ComboBox();
            this.thang_2 = new System.Windows.Forms.ComboBox();
            this.ngay_2 = new System.Windows.Forms.ComboBox();
            this.nam = new System.Windows.Forms.ComboBox();
            this.thang = new System.Windows.Forms.ComboBox();
            this.ngay = new System.Windows.Forms.ComboBox();
            this.cbb_LoaiThongKe = new System.Windows.Forms.ComboBox();
            this.lbl_TongVon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNgay = new DevExpress.XtraEditors.LabelControl();
            this.txtThang = new DevExpress.XtraEditors.LabelControl();
            this.txtNam = new DevExpress.XtraEditors.LabelControl();
            this.txtNgay2 = new DevExpress.XtraEditors.LabelControl();
            this.txtThang2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNam2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DonNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_DonNhap
            // 
            this.grid_DonNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grid_DonNhap.Location = new System.Drawing.Point(92, 121);
            this.grid_DonNhap.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grid_DonNhap.MainView = this.gridView1;
            this.grid_DonNhap.Name = "grid_DonNhap";
            this.grid_DonNhap.Size = new System.Drawing.Size(911, 381);
            this.grid_DonNhap.TabIndex = 38;
            this.grid_DonNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grid_DonNhap;
            this.gridView1.Name = "gridView1";
            // 
            // nam_2
            // 
            this.nam_2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nam_2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nam_2.FormattingEnabled = true;
            this.nam_2.Location = new System.Drawing.Point(917, 85);
            this.nam_2.Name = "nam_2";
            this.nam_2.Size = new System.Drawing.Size(86, 30);
            this.nam_2.TabIndex = 37;
            this.nam_2.SelectedIndexChanged += new System.EventHandler(this.nam_2_SelectedIndexChanged);
            // 
            // thang_2
            // 
            this.thang_2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.thang_2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thang_2.FormattingEnabled = true;
            this.thang_2.Location = new System.Drawing.Point(827, 85);
            this.thang_2.Name = "thang_2";
            this.thang_2.Size = new System.Drawing.Size(65, 30);
            this.thang_2.TabIndex = 36;
            this.thang_2.SelectedIndexChanged += new System.EventHandler(this.thang_2_SelectedIndexChanged);
            // 
            // ngay_2
            // 
            this.ngay_2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ngay_2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngay_2.FormattingEnabled = true;
            this.ngay_2.Location = new System.Drawing.Point(725, 85);
            this.ngay_2.Name = "ngay_2";
            this.ngay_2.Size = new System.Drawing.Size(77, 30);
            this.ngay_2.TabIndex = 35;
            this.ngay_2.SelectedIndexChanged += new System.EventHandler(this.ngay_2_SelectedIndexChanged);
            // 
            // nam
            // 
            this.nam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nam.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nam.FormattingEnabled = true;
            this.nam.Location = new System.Drawing.Point(575, 85);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(84, 30);
            this.nam.TabIndex = 34;
            this.nam.SelectedIndexChanged += new System.EventHandler(this.nam_SelectedIndexChanged);
            // 
            // thang
            // 
            this.thang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.thang.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thang.FormattingEnabled = true;
            this.thang.Location = new System.Drawing.Point(476, 85);
            this.thang.Name = "thang";
            this.thang.Size = new System.Drawing.Size(69, 30);
            this.thang.TabIndex = 33;
            this.thang.SelectedIndexChanged += new System.EventHandler(this.thang_SelectedIndexChanged);
            // 
            // ngay
            // 
            this.ngay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ngay.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngay.FormattingEnabled = true;
            this.ngay.Location = new System.Drawing.Point(390, 85);
            this.ngay.Name = "ngay";
            this.ngay.Size = new System.Drawing.Size(68, 30);
            this.ngay.TabIndex = 32;
            this.ngay.SelectedIndexChanged += new System.EventHandler(this.ngay_SelectedIndexChanged);
            // 
            // cbb_LoaiThongKe
            // 
            this.cbb_LoaiThongKe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbb_LoaiThongKe.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_LoaiThongKe.FormattingEnabled = true;
            this.cbb_LoaiThongKe.Items.AddRange(new object[] {
            "Báo Cáo Theo Ngày",
            "Báo Cáo Theo Tháng",
            "Báo Cáo Theo Năm",
            "Bao Cáo Theo Khoảng Thời Gian"});
            this.cbb_LoaiThongKe.Location = new System.Drawing.Point(92, 85);
            this.cbb_LoaiThongKe.Name = "cbb_LoaiThongKe";
            this.cbb_LoaiThongKe.Size = new System.Drawing.Size(226, 30);
            this.cbb_LoaiThongKe.TabIndex = 31;
            this.cbb_LoaiThongKe.SelectedIndexChanged += new System.EventHandler(this.cbb_LoaiThongKe_SelectedIndexChanged);
            // 
            // lbl_TongVon
            // 
            this.lbl_TongVon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TongVon.AutoSize = true;
            this.lbl_TongVon.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongVon.ForeColor = System.Drawing.Color.Red;
            this.lbl_TongVon.Location = new System.Drawing.Point(606, 59);
            this.lbl_TongVon.Name = "lbl_TongVon";
            this.lbl_TongVon.Size = new System.Drawing.Size(31, 32);
            this.lbl_TongVon.TabIndex = 40;
            this.lbl_TongVon.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(433, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 39;
            this.label1.Text = "Tổng Vốn:";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.labelControl6);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1082, 59);
            this.sidePanel1.TabIndex = 41;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl6.Location = new System.Drawing.Point(474, 13);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(173, 32);
            this.labelControl6.TabIndex = 26;
            this.labelControl6.Text = "TÍNH GIÁ VỐN";
            // 
            // sidePanel2
            // 
            this.sidePanel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidePanel2.Appearance.Options.UseBackColor = true;
            this.sidePanel2.Controls.Add(this.lbl_TongVon);
            this.sidePanel2.Controls.Add(this.label1);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel2.Location = new System.Drawing.Point(0, 508);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(1082, 130);
            this.sidePanel2.TabIndex = 42;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(92, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(138, 19);
            this.labelControl2.TabIndex = 43;
            this.labelControl2.Text = "Chọn Điều Kiện Lọc";
            // 
            // txtNgay
            // 
            this.txtNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNgay.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtNgay.Appearance.Options.UseFont = true;
            this.txtNgay.Appearance.Options.UseForeColor = true;
            this.txtNgay.Location = new System.Drawing.Point(390, 65);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(36, 19);
            this.txtNgay.TabIndex = 43;
            this.txtNgay.Text = "Ngày";
            // 
            // txtThang
            // 
            this.txtThang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtThang.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtThang.Appearance.Options.UseFont = true;
            this.txtThang.Appearance.Options.UseForeColor = true;
            this.txtThang.Location = new System.Drawing.Point(476, 65);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(45, 19);
            this.txtThang.TabIndex = 43;
            this.txtThang.Text = "Tháng";
            // 
            // txtNam
            // 
            this.txtNam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNam.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtNam.Appearance.Options.UseFont = true;
            this.txtNam.Appearance.Options.UseForeColor = true;
            this.txtNam.Location = new System.Drawing.Point(575, 65);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(33, 19);
            this.txtNam.TabIndex = 43;
            this.txtNam.Text = "Năm";
            // 
            // txtNgay2
            // 
            this.txtNgay2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNgay2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtNgay2.Appearance.Options.UseFont = true;
            this.txtNgay2.Appearance.Options.UseForeColor = true;
            this.txtNgay2.Location = new System.Drawing.Point(725, 65);
            this.txtNgay2.Name = "txtNgay2";
            this.txtNgay2.Size = new System.Drawing.Size(36, 19);
            this.txtNgay2.TabIndex = 43;
            this.txtNgay2.Text = "Ngày";
            // 
            // txtThang2
            // 
            this.txtThang2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtThang2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtThang2.Appearance.Options.UseFont = true;
            this.txtThang2.Appearance.Options.UseForeColor = true;
            this.txtThang2.Location = new System.Drawing.Point(827, 65);
            this.txtThang2.Name = "txtThang2";
            this.txtThang2.Size = new System.Drawing.Size(45, 19);
            this.txtThang2.TabIndex = 43;
            this.txtThang2.Text = "Tháng";
            // 
            // txtNam2
            // 
            this.txtNam2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNam2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtNam2.Appearance.Options.UseFont = true;
            this.txtNam2.Appearance.Options.UseForeColor = true;
            this.txtNam2.Location = new System.Drawing.Point(917, 65);
            this.txtNam2.Name = "txtNam2";
            this.txtNam2.Size = new System.Drawing.Size(33, 19);
            this.txtNam2.TabIndex = 43;
            this.txtNam2.Text = "Năm";
            // 
            // TinhGiaVon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtNam2);
            this.Controls.Add(this.txtThang2);
            this.Controls.Add(this.txtNgay2);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.grid_DonNhap);
            this.Controls.Add(this.nam_2);
            this.Controls.Add(this.thang_2);
            this.Controls.Add(this.ngay_2);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.thang);
            this.Controls.Add(this.ngay);
            this.Controls.Add(this.cbb_LoaiThongKe);
            this.Name = "TinhGiaVon";
            this.Size = new System.Drawing.Size(1082, 638);
            this.Load += new System.EventHandler(this.TinhGiaVon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_DonNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            this.sidePanel2.ResumeLayout(false);
            this.sidePanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid_DonNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ComboBox nam_2;
        private System.Windows.Forms.ComboBox thang_2;
        private System.Windows.Forms.ComboBox ngay_2;
        private System.Windows.Forms.ComboBox nam;
        private System.Windows.Forms.ComboBox thang;
        private System.Windows.Forms.ComboBox ngay;
        private System.Windows.Forms.ComboBox cbb_LoaiThongKe;
        private System.Windows.Forms.Label lbl_TongVon;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl txtNgay;
        private DevExpress.XtraEditors.LabelControl txtThang;
        private DevExpress.XtraEditors.LabelControl txtNam;
        private DevExpress.XtraEditors.LabelControl txtNgay2;
        private DevExpress.XtraEditors.LabelControl txtThang2;
        private DevExpress.XtraEditors.LabelControl txtNam2;
    }
}
