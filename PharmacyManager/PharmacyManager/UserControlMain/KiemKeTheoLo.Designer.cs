namespace PharmacyManager.UserControlMain
{
    partial class KiemKeTheoLo
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiemKeTheoLo));
            this.grid_KiemKeTheoLo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grid_CTDN = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.txt_MaDonNhap = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.alltien = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            this.btn_SuaDonNhap = new DevExpress.XtraEditors.SimpleButton();
            this.txt_mathuoc = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grid_KiemKeTheoLo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_CTDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            this.sidePanel3.SuspendLayout();
            this.sidePanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_KiemKeTheoLo
            // 
            this.grid_KiemKeTheoLo.Dock = System.Windows.Forms.DockStyle.Left;
            this.grid_KiemKeTheoLo.Location = new System.Drawing.Point(0, 0);
            this.grid_KiemKeTheoLo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grid_KiemKeTheoLo.MainView = this.gridView1;
            this.grid_KiemKeTheoLo.Name = "grid_KiemKeTheoLo";
            this.grid_KiemKeTheoLo.Size = new System.Drawing.Size(338, 263);
            this.grid_KiemKeTheoLo.TabIndex = 28;
            this.grid_KiemKeTheoLo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grid_KiemKeTheoLo.Click += new System.EventHandler(this.grid_KiemKeTheoLo_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grid_KiemKeTheoLo;
            this.gridView1.Name = "gridView1";
            // 
            // grid_CTDN
            // 
            this.grid_CTDN.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.grid_CTDN.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grid_CTDN.Location = new System.Drawing.Point(338, 0);
            this.grid_CTDN.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grid_CTDN.MainView = this.gridView2;
            this.grid_CTDN.Name = "grid_CTDN";
            this.grid_CTDN.Size = new System.Drawing.Size(828, 263);
            this.grid_CTDN.TabIndex = 27;
            this.grid_CTDN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grid_CTDN;
            this.gridView2.Name = "gridView2";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(63, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 173);
            this.panel1.TabIndex = 31;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.txt_MaDonNhap);
            this.sidePanel1.Controls.Add(this.labelControl1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1166, 59);
            this.sidePanel1.TabIndex = 36;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // txt_MaDonNhap
            // 
            this.txt_MaDonNhap.Location = new System.Drawing.Point(52, 24);
            this.txt_MaDonNhap.Name = "txt_MaDonNhap";
            this.txt_MaDonNhap.Size = new System.Drawing.Size(154, 21);
            this.txt_MaDonNhap.TabIndex = 26;
            this.txt_MaDonNhap.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_MaDonNhap_KeyUp);
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
            this.labelControl1.Location = new System.Drawing.Point(453, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(223, 32);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "KIỂM KÊ THEO LÔ";
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.grid_CTDN);
            this.sidePanel2.Controls.Add(this.grid_KiemKeTheoLo);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel2.Location = new System.Drawing.Point(0, 59);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(1166, 263);
            this.sidePanel2.TabIndex = 37;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // sidePanel3
            // 
            this.sidePanel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidePanel3.Appearance.Options.UseBackColor = true;
            this.sidePanel3.Controls.Add(this.simpleButton2);
            this.sidePanel3.Controls.Add(this.simpleButton1);
            this.sidePanel3.Controls.Add(this.alltien);
            this.sidePanel3.Controls.Add(this.labelControl5);
            this.sidePanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel3.Location = new System.Drawing.Point(0, 582);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.Size = new System.Drawing.Size(1166, 64);
            this.sidePanel3.TabIndex = 38;
            this.sidePanel3.Text = "sidePanel3";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(960, 16);
            this.simpleButton2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(143, 31);
            this.simpleButton2.TabIndex = 44;
            this.simpleButton2.Text = "Cập Nhật";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(63, 16);
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(143, 31);
            this.simpleButton1.TabIndex = 45;
            this.simpleButton1.Text = "Nhập Thuốc";
            // 
            // alltien
            // 
            this.alltien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alltien.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alltien.Location = new System.Drawing.Point(594, 18);
            this.alltien.Name = "alltien";
            this.alltien.Size = new System.Drawing.Size(109, 30);
            this.alltien.TabIndex = 43;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(494, 26);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(86, 22);
            this.labelControl5.TabIndex = 42;
            this.labelControl5.Text = "Tổng Tiền";
            // 
            // sidePanel4
            // 
            this.sidePanel4.Controls.Add(this.btn_SuaDonNhap);
            this.sidePanel4.Controls.Add(this.txt_mathuoc);
            this.sidePanel4.Controls.Add(this.labelControl4);
            this.sidePanel4.Controls.Add(this.panel1);
            this.sidePanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel4.Location = new System.Drawing.Point(0, 322);
            this.sidePanel4.Name = "sidePanel4";
            this.sidePanel4.Size = new System.Drawing.Size(1166, 260);
            this.sidePanel4.TabIndex = 39;
            this.sidePanel4.Text = "sidePanel4";
            // 
            // btn_SuaDonNhap
            // 
            this.btn_SuaDonNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_SuaDonNhap.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaDonNhap.Appearance.Options.UseFont = true;
            this.btn_SuaDonNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaDonNhap.ImageOptions.Image")));
            this.btn_SuaDonNhap.Location = new System.Drawing.Point(960, 23);
            this.btn_SuaDonNhap.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_SuaDonNhap.Name = "btn_SuaDonNhap";
            this.btn_SuaDonNhap.Size = new System.Drawing.Size(143, 31);
            this.btn_SuaDonNhap.TabIndex = 44;
            this.btn_SuaDonNhap.Text = "Sửa Đơn Nhập";
            this.btn_SuaDonNhap.Click += new System.EventHandler(this.btn_SuaDonNhap_Click);
            // 
            // txt_mathuoc
            // 
            this.txt_mathuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_mathuoc.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mathuoc.Location = new System.Drawing.Point(138, 20);
            this.txt_mathuoc.Name = "txt_mathuoc";
            this.txt_mathuoc.Size = new System.Drawing.Size(151, 30);
            this.txt_mathuoc.TabIndex = 43;
            this.txt_mathuoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_mathuoc_KeyDown);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(63, 26);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 19);
            this.labelControl4.TabIndex = 42;
            this.labelControl4.Text = "Mã Thuốc";
            // 
            // KiemKeTheoLo
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel4);
            this.Controls.Add(this.sidePanel3);
            this.Controls.Add(this.sidePanel1);
            this.Name = "KiemKeTheoLo";
            this.Size = new System.Drawing.Size(1166, 646);
            this.Load += new System.EventHandler(this.KiemKeTheoLo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_KiemKeTheoLo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_CTDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            this.sidePanel2.ResumeLayout(false);
            this.sidePanel3.ResumeLayout(false);
            this.sidePanel3.PerformLayout();
            this.sidePanel4.ResumeLayout(false);
            this.sidePanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid_KiemKeTheoLo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grid_CTDN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.FlowLayoutPanel panel1;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SidePanel sidePanel3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox alltien;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraEditors.SimpleButton btn_SuaDonNhap;
        private System.Windows.Forms.TextBox txt_mathuoc;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txt_MaDonNhap;
    }
}
