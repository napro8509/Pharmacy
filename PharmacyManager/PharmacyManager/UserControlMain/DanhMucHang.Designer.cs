namespace PharmacyManager.UserControlMain
{
    partial class DanhMucHang
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
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.cbb_LoaiThuoc = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.btn_CapNhatThuoc = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.sidePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.White;
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Controls.Add(this.cbb_LoaiThuoc);
            this.sidePanel1.Controls.Add(this.labelControl1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1076, 92);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // cbb_LoaiThuoc
            // 
            this.cbb_LoaiThuoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_LoaiThuoc.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_LoaiThuoc.FormattingEnabled = true;
            this.cbb_LoaiThuoc.Items.AddRange(new object[] {
            "Thuốc bán theo đơn ",
            "Thuốc bán theo hộp",
            "Thuốc Bắt Buộc của bác sĩ",
            "Thuốc Ngừng Bán",
            "Tất Cả Thuốc"});
            this.cbb_LoaiThuoc.Location = new System.Drawing.Point(426, 54);
            this.cbb_LoaiThuoc.Name = "cbb_LoaiThuoc";
            this.cbb_LoaiThuoc.Size = new System.Drawing.Size(213, 30);
            this.cbb_LoaiThuoc.TabIndex = 34;
            this.cbb_LoaiThuoc.SelectedIndexChanged += new System.EventHandler(this.cbb_LoaiThuoc_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.Location = new System.Drawing.Point(426, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(213, 32);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "DANH MỤC HÀNG";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gridControl1.Location = new System.Drawing.Point(38, 98);
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(996, 513);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // sidePanel2
            // 
            this.sidePanel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidePanel2.Appearance.Options.UseBackColor = true;
            this.sidePanel2.Controls.Add(this.btn_CapNhatThuoc);
            this.sidePanel2.Controls.Add(this.simpleButton2);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel2.Location = new System.Drawing.Point(0, 617);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(1076, 91);
            this.sidePanel2.TabIndex = 2;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // btn_CapNhatThuoc
            // 
            this.btn_CapNhatThuoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CapNhatThuoc.Appearance.BackColor = System.Drawing.Color.Black;
            this.btn_CapNhatThuoc.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhatThuoc.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_CapNhatThuoc.Appearance.Options.UseBackColor = true;
            this.btn_CapNhatThuoc.Appearance.Options.UseFont = true;
            this.btn_CapNhatThuoc.Appearance.Options.UseForeColor = true;
            this.btn_CapNhatThuoc.Appearance.Options.UseTextOptions = true;
            this.btn_CapNhatThuoc.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_CapNhatThuoc.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_CapNhatThuoc.AppearanceHovered.Options.UseBackColor = true;
            this.btn_CapNhatThuoc.ImageOptions.Image = global::PharmacyManager.Properties.Resources.icon_add_thuoc;
            this.btn_CapNhatThuoc.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_CapNhatThuoc.Location = new System.Drawing.Point(282, 10);
            this.btn_CapNhatThuoc.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_CapNhatThuoc.Name = "btn_CapNhatThuoc";
            this.btn_CapNhatThuoc.Size = new System.Drawing.Size(169, 67);
            this.btn_CapNhatThuoc.TabIndex = 28;
            this.btn_CapNhatThuoc.Text = "CẬP NHẬT THUỐC";
            this.btn_CapNhatThuoc.Click += new System.EventHandler(this.btn_CapNhatThuoc_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Black;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.Appearance.Options.UseTextOptions = true;
            this.simpleButton2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton2.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.simpleButton2.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton2.ImageOptions.Image = global::PharmacyManager.Properties.Resources.icon_add_thuoc;
            this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton2.Location = new System.Drawing.Point(638, 9);
            this.simpleButton2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(169, 67);
            this.simpleButton2.TabIndex = 27;
            this.simpleButton2.Text = "THÊM THUỐC MỚI";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // DanhMucHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "DanhMucHang";
            this.Size = new System.Drawing.Size(1076, 708);
            this.Load += new System.EventHandler(this.DanhMucHang_Load);
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.sidePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btn_CapNhatThuoc;
        private System.Windows.Forms.ComboBox cbb_LoaiThuoc;
    }
}
