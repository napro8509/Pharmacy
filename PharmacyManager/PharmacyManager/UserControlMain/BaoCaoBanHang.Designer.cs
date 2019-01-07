namespace PharmacyManager.UserControlMain
{
    partial class BaoCaoBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCaoBanHang));
            this.grid_baoCaoBanHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbb_LoaiThongKe = new System.Windows.Forms.ComboBox();
            this.nam = new System.Windows.Forms.ComboBox();
            this.thang = new System.Windows.Forms.ComboBox();
            this.ngay = new System.Windows.Forms.ComboBox();
            this.nam_2 = new System.Windows.Forms.ComboBox();
            this.thang_2 = new System.Windows.Forms.ComboBox();
            this.ngay_2 = new System.Windows.Forms.ComboBox();
            this.cbb_DuocSy = new System.Windows.Forms.ComboBox();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.txt_MaDonBan = new System.Windows.Forms.TextBox();
            this.txtNam2 = new DevExpress.XtraEditors.LabelControl();
            this.txtThang2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNam1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNgay2 = new DevExpress.XtraEditors.LabelControl();
            this.txtThang1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNgay1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.alltien = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grid_CTDonThuoc = new DevExpress.XtraGrid.GridControl();
            this.txt_mathuoc = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            this.btn_SuaDonNhap = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbb_SoLieu = new System.Windows.Forms.ComboBox();
            this.cb_ThuocNhayCam = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_baoCaoBanHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_CTDonThuoc)).BeginInit();
            this.sidePanel3.SuspendLayout();
            this.sidePanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_baoCaoBanHang
            // 
            this.grid_baoCaoBanHang.Dock = System.Windows.Forms.DockStyle.Left;
            gridLevelNode1.RelationName = "Level1";
            this.grid_baoCaoBanHang.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grid_baoCaoBanHang.Location = new System.Drawing.Point(0, 0);
            this.grid_baoCaoBanHang.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grid_baoCaoBanHang.MainView = this.gridView1;
            this.grid_baoCaoBanHang.Name = "grid_baoCaoBanHang";
            this.grid_baoCaoBanHang.Size = new System.Drawing.Size(617, 405);
            this.grid_baoCaoBanHang.TabIndex = 0;
            this.grid_baoCaoBanHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grid_baoCaoBanHang.Load += new System.EventHandler(this.grid_baoCaoBanHang_Load);
            this.grid_baoCaoBanHang.Click += new System.EventHandler(this.grid_baoCaoBanHang_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grid_baoCaoBanHang;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
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
            "Bao Cáo Theo Khoảng Thời Gian",
            "Báo Cáo Theo Dược Viên",
            "Báo Cáo Theo Đơn",
            "Các Đơn Thuốc Nhạy Cảm"});
            this.cbb_LoaiThongKe.Location = new System.Drawing.Point(196, 68);
            this.cbb_LoaiThongKe.Name = "cbb_LoaiThongKe";
            this.cbb_LoaiThongKe.Size = new System.Drawing.Size(212, 30);
            this.cbb_LoaiThongKe.TabIndex = 4;
            this.cbb_LoaiThongKe.SelectedIndexChanged += new System.EventHandler(this.cbb_LoaiThongKe_SelectedIndexChanged);
            // 
            // nam
            // 
            this.nam.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nam.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nam.FormattingEnabled = true;
            this.nam.Location = new System.Drawing.Point(771, 68);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(80, 30);
            this.nam.TabIndex = 17;
            this.nam.SelectedIndexChanged += new System.EventHandler(this.nam_SelectedIndexChanged);
            // 
            // thang
            // 
            this.thang.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.thang.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thang.FormattingEnabled = true;
            this.thang.Location = new System.Drawing.Point(699, 68);
            this.thang.Name = "thang";
            this.thang.Size = new System.Drawing.Size(62, 30);
            this.thang.TabIndex = 16;
            this.thang.SelectedIndexChanged += new System.EventHandler(this.thang_SelectedIndexChanged);
            // 
            // ngay
            // 
            this.ngay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ngay.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngay.FormattingEnabled = true;
            this.ngay.Location = new System.Drawing.Point(631, 68);
            this.ngay.Name = "ngay";
            this.ngay.Size = new System.Drawing.Size(62, 30);
            this.ngay.TabIndex = 15;
            this.ngay.SelectedIndexChanged += new System.EventHandler(this.ngay_SelectedIndexChanged);
            // 
            // nam_2
            // 
            this.nam_2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nam_2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nam_2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.nam_2.FormattingEnabled = true;
            this.nam_2.Location = new System.Drawing.Point(997, 68);
            this.nam_2.Name = "nam_2";
            this.nam_2.Size = new System.Drawing.Size(79, 30);
            this.nam_2.TabIndex = 20;
            this.nam_2.SelectedIndexChanged += new System.EventHandler(this.nam_2_SelectedIndexChanged);
            // 
            // thang_2
            // 
            this.thang_2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.thang_2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thang_2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.thang_2.FormattingEnabled = true;
            this.thang_2.Location = new System.Drawing.Point(928, 68);
            this.thang_2.Name = "thang_2";
            this.thang_2.Size = new System.Drawing.Size(63, 30);
            this.thang_2.TabIndex = 19;
            this.thang_2.SelectedIndexChanged += new System.EventHandler(this.thang_2_SelectedIndexChanged);
            // 
            // ngay_2
            // 
            this.ngay_2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ngay_2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngay_2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ngay_2.FormattingEnabled = true;
            this.ngay_2.Location = new System.Drawing.Point(864, 68);
            this.ngay_2.Name = "ngay_2";
            this.ngay_2.Size = new System.Drawing.Size(58, 30);
            this.ngay_2.TabIndex = 18;
            this.ngay_2.SelectedIndexChanged += new System.EventHandler(this.ngay_2_SelectedIndexChanged);
            // 
            // cbb_DuocSy
            // 
            this.cbb_DuocSy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbb_DuocSy.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_DuocSy.FormattingEnabled = true;
            this.cbb_DuocSy.Location = new System.Drawing.Point(414, 68);
            this.cbb_DuocSy.Name = "cbb_DuocSy";
            this.cbb_DuocSy.Size = new System.Drawing.Size(176, 30);
            this.cbb_DuocSy.TabIndex = 21;
            this.cbb_DuocSy.SelectedIndexChanged += new System.EventHandler(this.cbb_DuocSy_SelectedIndexChanged);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.White;
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Controls.Add(this.cb_ThuocNhayCam);
            this.sidePanel1.Controls.Add(this.txt_MaDonBan);
            this.sidePanel1.Controls.Add(this.txtNam2);
            this.sidePanel1.Controls.Add(this.txtThang2);
            this.sidePanel1.Controls.Add(this.txtNam1);
            this.sidePanel1.Controls.Add(this.txtNgay2);
            this.sidePanel1.Controls.Add(this.txtThang1);
            this.sidePanel1.Controls.Add(this.txtNgay1);
            this.sidePanel1.Controls.Add(this.labelControl3);
            this.sidePanel1.Controls.Add(this.labelControl2);
            this.sidePanel1.Controls.Add(this.labelControl1);
            this.sidePanel1.Controls.Add(this.nam_2);
            this.sidePanel1.Controls.Add(this.thang_2);
            this.sidePanel1.Controls.Add(this.ngay_2);
            this.sidePanel1.Controls.Add(this.cbb_DuocSy);
            this.sidePanel1.Controls.Add(this.cbb_LoaiThongKe);
            this.sidePanel1.Controls.Add(this.ngay);
            this.sidePanel1.Controls.Add(this.thang);
            this.sidePanel1.Controls.Add(this.nam);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1234, 117);
            this.sidePanel1.TabIndex = 22;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // txt_MaDonBan
            // 
            this.txt_MaDonBan.Location = new System.Drawing.Point(242, 11);
            this.txt_MaDonBan.Name = "txt_MaDonBan";
            this.txt_MaDonBan.Size = new System.Drawing.Size(137, 20);
            this.txt_MaDonBan.TabIndex = 26;
            this.txt_MaDonBan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MaDonBan_KeyDown);
            this.txt_MaDonBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MaDonBan_KeyPress);
            this.txt_MaDonBan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_MaDonBan_KeyUp);
            // 
            // txtNam2
            // 
            this.txtNam2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNam2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtNam2.Appearance.Options.UseFont = true;
            this.txtNam2.Appearance.Options.UseForeColor = true;
            this.txtNam2.Location = new System.Drawing.Point(1005, 43);
            this.txtNam2.Name = "txtNam2";
            this.txtNam2.Size = new System.Drawing.Size(33, 19);
            this.txtNam2.TabIndex = 25;
            this.txtNam2.Text = "Năm";
            // 
            // txtThang2
            // 
            this.txtThang2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtThang2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtThang2.Appearance.Options.UseFont = true;
            this.txtThang2.Appearance.Options.UseForeColor = true;
            this.txtThang2.Location = new System.Drawing.Point(933, 43);
            this.txtThang2.Name = "txtThang2";
            this.txtThang2.Size = new System.Drawing.Size(45, 19);
            this.txtThang2.TabIndex = 25;
            this.txtThang2.Text = "Tháng";
            // 
            // txtNam1
            // 
            this.txtNam1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNam1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtNam1.Appearance.Options.UseFont = true;
            this.txtNam1.Appearance.Options.UseForeColor = true;
            this.txtNam1.Location = new System.Drawing.Point(771, 43);
            this.txtNam1.Name = "txtNam1";
            this.txtNam1.Size = new System.Drawing.Size(33, 19);
            this.txtNam1.TabIndex = 25;
            this.txtNam1.Text = "Năm";
            // 
            // txtNgay2
            // 
            this.txtNgay2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNgay2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtNgay2.Appearance.Options.UseFont = true;
            this.txtNgay2.Appearance.Options.UseForeColor = true;
            this.txtNgay2.Location = new System.Drawing.Point(865, 43);
            this.txtNgay2.Name = "txtNgay2";
            this.txtNgay2.Size = new System.Drawing.Size(36, 19);
            this.txtNgay2.TabIndex = 25;
            this.txtNgay2.Text = "Ngày";
            // 
            // txtThang1
            // 
            this.txtThang1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtThang1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtThang1.Appearance.Options.UseFont = true;
            this.txtThang1.Appearance.Options.UseForeColor = true;
            this.txtThang1.Location = new System.Drawing.Point(699, 43);
            this.txtThang1.Name = "txtThang1";
            this.txtThang1.Size = new System.Drawing.Size(45, 19);
            this.txtThang1.TabIndex = 25;
            this.txtThang1.Text = "Tháng";
            // 
            // txtNgay1
            // 
            this.txtNgay1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNgay1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtNgay1.Appearance.Options.UseFont = true;
            this.txtNgay1.Appearance.Options.UseForeColor = true;
            this.txtNgay1.Location = new System.Drawing.Point(631, 43);
            this.txtNgay1.Name = "txtNgay1";
            this.txtNgay1.Size = new System.Drawing.Size(36, 19);
            this.txtNgay1.TabIndex = 25;
            this.txtNgay1.Text = "Ngày";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(414, 43);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(101, 19);
            this.labelControl3.TabIndex = 25;
            this.labelControl3.Text = "Chọn Dược Sỹ";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(196, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(138, 19);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "Chọn Điều Kiện Lọc";
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
            this.labelControl1.Location = new System.Drawing.Point(441, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(385, 32);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "BÁO CÁO THỐNG KÊ BÁN HÀNG";
            // 
            // sidePanel2
            // 
            this.sidePanel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidePanel2.Appearance.Options.UseBackColor = true;
            this.sidePanel2.Controls.Add(this.simpleButton2);
            this.sidePanel2.Controls.Add(this.simpleButton1);
            this.sidePanel2.Controls.Add(this.alltien);
            this.sidePanel2.Controls.Add(this.labelControl5);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel2.Location = new System.Drawing.Point(0, 744);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(1234, 65);
            this.sidePanel2.TabIndex = 23;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(997, 17);
            this.simpleButton2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(143, 31);
            this.simpleButton2.TabIndex = 41;
            this.simpleButton2.Text = "Cập Nhật";
            this.simpleButton2.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(100, 17);
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(143, 31);
            this.simpleButton1.TabIndex = 41;
            this.simpleButton1.Text = "Nhập Thuốc";
            this.simpleButton1.Click += new System.EventHandler(this.btn_nhapthuoc_Click);
            // 
            // alltien
            // 
            this.alltien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alltien.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alltien.Location = new System.Drawing.Point(631, 19);
            this.alltien.Name = "alltien";
            this.alltien.Size = new System.Drawing.Size(109, 30);
            this.alltien.TabIndex = 40;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(531, 27);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(86, 22);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "Tổng Tiền";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grid_CTDonThuoc;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsFind.AlwaysVisible = true;
            // 
            // grid_CTDonThuoc
            // 
            this.grid_CTDonThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_CTDonThuoc.Location = new System.Drawing.Point(617, 0);
            this.grid_CTDonThuoc.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grid_CTDonThuoc.MainView = this.gridView2;
            this.grid_CTDonThuoc.Name = "grid_CTDonThuoc";
            this.grid_CTDonThuoc.Size = new System.Drawing.Size(617, 405);
            this.grid_CTDonThuoc.TabIndex = 24;
            this.grid_CTDonThuoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.grid_CTDonThuoc.Load += new System.EventHandler(this.grid_CTDonThuoc_Load);
            // 
            // txt_mathuoc
            // 
            this.txt_mathuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_mathuoc.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mathuoc.Location = new System.Drawing.Point(175, 3);
            this.txt_mathuoc.Name = "txt_mathuoc";
            this.txt_mathuoc.Size = new System.Drawing.Size(151, 30);
            this.txt_mathuoc.TabIndex = 38;
            this.txt_mathuoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_mathuoc_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(97, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 176);
            this.panel1.TabIndex = 36;
            // 
            // sidePanel3
            // 
            this.sidePanel3.Controls.Add(this.grid_CTDonThuoc);
            this.sidePanel3.Controls.Add(this.grid_baoCaoBanHang);
            this.sidePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel3.Location = new System.Drawing.Point(0, 117);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.Size = new System.Drawing.Size(1234, 405);
            this.sidePanel3.TabIndex = 42;
            this.sidePanel3.Text = "sidePanel3";
            // 
            // sidePanel4
            // 
            this.sidePanel4.Appearance.BackColor = System.Drawing.Color.White;
            this.sidePanel4.Appearance.Options.UseBackColor = true;
            this.sidePanel4.Controls.Add(this.cbb_SoLieu);
            this.sidePanel4.Controls.Add(this.btn_SuaDonNhap);
            this.sidePanel4.Controls.Add(this.panel1);
            this.sidePanel4.Controls.Add(this.txt_mathuoc);
            this.sidePanel4.Controls.Add(this.labelControl4);
            this.sidePanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel4.Location = new System.Drawing.Point(0, 522);
            this.sidePanel4.Name = "sidePanel4";
            this.sidePanel4.Size = new System.Drawing.Size(1234, 222);
            this.sidePanel4.TabIndex = 42;
            this.sidePanel4.Text = "sidePanel4";
            // 
            // btn_SuaDonNhap
            // 
            this.btn_SuaDonNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_SuaDonNhap.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaDonNhap.Appearance.Options.UseFont = true;
            this.btn_SuaDonNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaDonNhap.ImageOptions.Image")));
            this.btn_SuaDonNhap.Location = new System.Drawing.Point(997, 6);
            this.btn_SuaDonNhap.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_SuaDonNhap.Name = "btn_SuaDonNhap";
            this.btn_SuaDonNhap.Size = new System.Drawing.Size(143, 31);
            this.btn_SuaDonNhap.TabIndex = 41;
            this.btn_SuaDonNhap.Text = "Sửa Đơn Nhập";
            this.btn_SuaDonNhap.Click += new System.EventHandler(this.btn_SuaDonNhap_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(100, 9);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 19);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "Mã Thuốc";
            // 
            // cbb_SoLieu
            // 
            this.cbb_SoLieu.FormattingEnabled = true;
            this.cbb_SoLieu.Location = new System.Drawing.Point(572, 11);
            this.cbb_SoLieu.Name = "cbb_SoLieu";
            this.cbb_SoLieu.Size = new System.Drawing.Size(121, 21);
            this.cbb_SoLieu.TabIndex = 42;
            // 
            // cb_ThuocNhayCam
            // 
            this.cb_ThuocNhayCam.AutoSize = true;
            this.cb_ThuocNhayCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ThuocNhayCam.ForeColor = System.Drawing.Color.Black;
            this.cb_ThuocNhayCam.Location = new System.Drawing.Point(1023, 15);
            this.cb_ThuocNhayCam.Name = "cb_ThuocNhayCam";
            this.cb_ThuocNhayCam.Size = new System.Drawing.Size(226, 24);
            this.cb_ThuocNhayCam.TabIndex = 27;
            this.cb_ThuocNhayCam.Text = "Là Đơn Thuốc Nhạy Cảm";
            this.cb_ThuocNhayCam.UseVisualStyleBackColor = true;
            this.cb_ThuocNhayCam.CheckedChanged += new System.EventHandler(this.cb_ThuocNhayCam_CheckedChanged);
            // 
            // BaoCaoBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.sidePanel3);
            this.Controls.Add(this.sidePanel4);
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel1);
            this.Name = "BaoCaoBanHang";
            this.Size = new System.Drawing.Size(1234, 809);
            this.Load += new System.EventHandler(this.BaoCaoBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_baoCaoBanHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            this.sidePanel2.ResumeLayout(false);
            this.sidePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_CTDonThuoc)).EndInit();
            this.sidePanel3.ResumeLayout(false);
            this.sidePanel4.ResumeLayout(false);
            this.sidePanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid_baoCaoBanHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ComboBox cbb_LoaiThongKe;
        private System.Windows.Forms.ComboBox nam;
        private System.Windows.Forms.ComboBox thang;
        private System.Windows.Forms.ComboBox ngay;
        private System.Windows.Forms.ComboBox nam_2;
        private System.Windows.Forms.ComboBox thang_2;
        private System.Windows.Forms.ComboBox ngay_2;
        private System.Windows.Forms.ComboBox cbb_DuocSy;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl txtNam1;
        private DevExpress.XtraEditors.LabelControl txtThang1;
        private DevExpress.XtraEditors.LabelControl txtNgay1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl txtNam2;
        private DevExpress.XtraEditors.LabelControl txtThang2;
        private DevExpress.XtraEditors.LabelControl txtNgay2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl grid_CTDonThuoc;
        private System.Windows.Forms.TextBox alltien;
        private System.Windows.Forms.TextBox txt_mathuoc;
        private System.Windows.Forms.FlowLayoutPanel panel1;
        private DevExpress.XtraEditors.SidePanel sidePanel3;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btn_SuaDonNhap;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txt_MaDonBan;
        private System.Windows.Forms.ComboBox cbb_SoLieu;
        private System.Windows.Forms.CheckBox cb_ThuocNhayCam;
    }
}
