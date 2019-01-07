namespace PharmacyManager.UserControlMain
{
    partial class TraThuocHetHan
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grid_DSThuocSapHetHan = new DevExpress.XtraGrid.GridControl();
            this.grid_DSTraThuoc = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel5 = new DevExpress.XtraEditors.SidePanel();
            this.btn_TraThuoc = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DSThuocSapHetHan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DSTraThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            this.sidePanel4.SuspendLayout();
            this.sidePanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grid_DSThuocSapHetHan;
            this.gridView1.Name = "gridView1";
            // 
            // grid_DSThuocSapHetHan
            // 
            this.grid_DSThuocSapHetHan.Dock = System.Windows.Forms.DockStyle.Left;
            this.grid_DSThuocSapHetHan.Location = new System.Drawing.Point(0, 0);
            this.grid_DSThuocSapHetHan.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grid_DSThuocSapHetHan.MainView = this.gridView1;
            this.grid_DSThuocSapHetHan.Name = "grid_DSThuocSapHetHan";
            this.grid_DSThuocSapHetHan.Size = new System.Drawing.Size(682, 220);
            this.grid_DSThuocSapHetHan.TabIndex = 0;
            this.grid_DSThuocSapHetHan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // grid_DSTraThuoc
            // 
            this.grid_DSTraThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_DSTraThuoc.Location = new System.Drawing.Point(682, 0);
            this.grid_DSTraThuoc.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grid_DSTraThuoc.MainView = this.gridView2;
            this.grid_DSTraThuoc.Name = "grid_DSTraThuoc";
            this.grid_DSTraThuoc.Size = new System.Drawing.Size(566, 220);
            this.grid_DSTraThuoc.TabIndex = 20;
            this.grid_DSTraThuoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.grid_DSTraThuoc.Click += new System.EventHandler(this.grid_DSTraThuoc_Click);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grid_DSTraThuoc;
            this.gridView2.Name = "gridView2";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.sidePanel3);
            this.sidePanel1.Controls.Add(this.sidePanel2);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1248, 144);
            this.sidePanel1.TabIndex = 21;
            this.sidePanel1.Text = "sidePanel1";
            this.sidePanel1.Click += new System.EventHandler(this.sidePanel1_Click);
            // 
            // sidePanel3
            // 
            this.sidePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel3.Location = new System.Drawing.Point(0, 47);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.Size = new System.Drawing.Size(1248, 96);
            this.sidePanel3.TabIndex = 20;
            this.sidePanel3.Text = "sidePanel3";
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.labelControl5);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel2.Location = new System.Drawing.Point(0, 0);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(1248, 47);
            this.sidePanel2.TabIndex = 19;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl5.Location = new System.Drawing.Point(544, 9);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(266, 32);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "TRẢ THUỐC HẾT HẠN";
            // 
            // sidePanel4
            // 
            this.sidePanel4.Controls.Add(this.grid_DSTraThuoc);
            this.sidePanel4.Controls.Add(this.grid_DSThuocSapHetHan);
            this.sidePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel4.Location = new System.Drawing.Point(0, 144);
            this.sidePanel4.Name = "sidePanel4";
            this.sidePanel4.Size = new System.Drawing.Size(1248, 220);
            this.sidePanel4.TabIndex = 22;
            this.sidePanel4.Text = "sidePanel4";
            // 
            // sidePanel5
            // 
            this.sidePanel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidePanel5.Appearance.Options.UseBackColor = true;
            this.sidePanel5.Controls.Add(this.btn_TraThuoc);
            this.sidePanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel5.Location = new System.Drawing.Point(0, 364);
            this.sidePanel5.Name = "sidePanel5";
            this.sidePanel5.Size = new System.Drawing.Size(1248, 98);
            this.sidePanel5.TabIndex = 23;
            this.sidePanel5.Text = "sidePanel5";
            // 
            // btn_TraThuoc
            // 
            this.btn_TraThuoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_TraThuoc.Appearance.BackColor = System.Drawing.Color.Black;
            this.btn_TraThuoc.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TraThuoc.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_TraThuoc.Appearance.Options.UseBackColor = true;
            this.btn_TraThuoc.Appearance.Options.UseFont = true;
            this.btn_TraThuoc.Appearance.Options.UseForeColor = true;
            this.btn_TraThuoc.Appearance.Options.UseTextOptions = true;
            this.btn_TraThuoc.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_TraThuoc.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_TraThuoc.AppearanceHovered.Options.UseBackColor = true;
            this.btn_TraThuoc.ImageOptions.Image = global::PharmacyManager.Properties.Resources.icon_tra_hang;
            this.btn_TraThuoc.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_TraThuoc.Location = new System.Drawing.Point(590, 6);
            this.btn_TraThuoc.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_TraThuoc.Name = "btn_TraThuoc";
            this.btn_TraThuoc.Size = new System.Drawing.Size(166, 75);
            this.btn_TraThuoc.TabIndex = 27;
            this.btn_TraThuoc.Text = "TRẢ THUỐC";
            this.btn_TraThuoc.Click += new System.EventHandler(this.btn_TraThuoc_Click_1);
            // 
            // TraThuocHetHan
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanel4);
            this.Controls.Add(this.sidePanel5);
            this.Controls.Add(this.sidePanel1);
            this.Name = "TraThuocHetHan";
            this.Size = new System.Drawing.Size(1248, 462);
            this.Load += new System.EventHandler(this.TraThuocHetHan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DSThuocSapHetHan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DSTraThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel2.ResumeLayout(false);
            this.sidePanel2.PerformLayout();
            this.sidePanel4.ResumeLayout(false);
            this.sidePanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grid_DSThuocSapHetHan;
        private DevExpress.XtraGrid.GridControl grid_DSTraThuoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SidePanel sidePanel3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraEditors.SidePanel sidePanel5;
        private DevExpress.XtraEditors.SimpleButton btn_TraThuoc;
    }
}
