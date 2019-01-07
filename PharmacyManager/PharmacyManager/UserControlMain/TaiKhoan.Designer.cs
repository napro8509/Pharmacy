namespace PharmacyManager.UserControlMain
{
    partial class TaiKhoan
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
            this.grid_DSTaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DSTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_DSTaiKhoan
            // 
            this.grid_DSTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grid_DSTaiKhoan.Location = new System.Drawing.Point(81, 88);
            this.grid_DSTaiKhoan.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grid_DSTaiKhoan.MainView = this.gridView1;
            this.grid_DSTaiKhoan.Name = "grid_DSTaiKhoan";
            this.grid_DSTaiKhoan.Size = new System.Drawing.Size(937, 451);
            this.grid_DSTaiKhoan.TabIndex = 61;
            this.grid_DSTaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grid_DSTaiKhoan.Load += new System.EventHandler(this.grid_DSTaiKhoan_Load);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grid_DSTaiKhoan;
            this.gridView1.Name = "gridView1";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.White;
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Controls.Add(this.labelControl1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1086, 82);
            this.sidePanel1.TabIndex = 64;
            this.sidePanel1.Text = "sidePanel1";
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
            this.labelControl1.Location = new System.Drawing.Point(411, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(250, 32);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // sidePanel2
            // 
            this.sidePanel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidePanel2.Appearance.Options.UseBackColor = true;
            this.sidePanel2.Controls.Add(this.simpleButton1);
            this.sidePanel2.Controls.Add(this.simpleButton2);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel2.Location = new System.Drawing.Point(0, 545);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(1086, 93);
            this.sidePanel2.TabIndex = 65;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton1.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton1.ImageOptions.Image = global::PharmacyManager.Properties.Resources.icon_check;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(718, 14);
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(169, 67);
            this.simpleButton1.TabIndex = 28;
            this.simpleButton1.Text = "CẬP NHẬT";
            this.simpleButton1.Click += new System.EventHandler(this.btn_CapNhatTaiKhoan_Click);
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
            this.simpleButton2.Location = new System.Drawing.Point(167, 14);
            this.simpleButton2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(169, 67);
            this.simpleButton2.TabIndex = 28;
            this.simpleButton2.Text = "THÊM MỚI";
            this.simpleButton2.Click += new System.EventHandler(this.btn_ThemMoi_Click);
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.grid_DSTaiKhoan);
            this.Name = "TaiKhoan";
            this.Size = new System.Drawing.Size(1086, 638);
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_DSTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            this.sidePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl grid_DSTaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}
