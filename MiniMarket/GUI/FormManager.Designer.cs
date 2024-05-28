namespace MiniMarket
{
    partial class FormManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager));
            this.pnMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnImportProduct = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnTaiKhoan = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblEmail = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnLogout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSanPham = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnKhachHang = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnOrder = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pcbIcon = new System.Windows.Forms.PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnOutStockAlert = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.pnMenu.Controls.Add(this.btnOutStockAlert);
            this.pnMenu.Controls.Add(this.btnImportProduct);
            this.pnMenu.Controls.Add(this.btnTaiKhoan);
            this.pnMenu.Controls.Add(this.lblEmail);
            this.pnMenu.Controls.Add(this.guna2Separator1);
            this.pnMenu.Controls.Add(this.btnLogout);
            this.pnMenu.Controls.Add(this.btnSanPham);
            this.pnMenu.Controls.Add(this.btnKhachHang);
            this.pnMenu.Controls.Add(this.btnOrder);
            this.pnMenu.Controls.Add(this.lbl1);
            this.pnMenu.Controls.Add(this.pcbIcon);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(258, 725);
            this.pnMenu.TabIndex = 1;
            // 
            // btnImportProduct
            // 
            this.btnImportProduct.Animated = true;
            this.btnImportProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnImportProduct.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnImportProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportProduct.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnImportProduct.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnImportProduct.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.btnImportProduct.FillColor = System.Drawing.Color.Empty;
            this.btnImportProduct.FillColor2 = System.Drawing.Color.Empty;
            this.btnImportProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnImportProduct.ForeColor = System.Drawing.Color.White;
            this.btnImportProduct.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnImportProduct.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnImportProduct.Location = new System.Drawing.Point(5, 460);
            this.btnImportProduct.Name = "btnImportProduct";
            this.btnImportProduct.Size = new System.Drawing.Size(241, 45);
            this.btnImportProduct.TabIndex = 4;
            this.btnImportProduct.Text = "Nhập Hàng";
            this.btnImportProduct.UseTransparentBackground = true;
            this.btnImportProduct.Click += new System.EventHandler(this.btnImportProduct_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Animated = true;
            this.btnTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.btnTaiKhoan.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaiKhoan.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnTaiKhoan.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTaiKhoan.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.btnTaiKhoan.FillColor = System.Drawing.Color.Empty;
            this.btnTaiKhoan.FillColor2 = System.Drawing.Color.Empty;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnTaiKhoan.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnTaiKhoan.Location = new System.Drawing.Point(5, 398);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(241, 45);
            this.btnTaiKhoan.TabIndex = 4;
            this.btnTaiKhoan.Text = "Tài Khoản";
            this.btnTaiKhoan.UseTransparentBackground = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblEmail.Location = new System.Drawing.Point(9, 596);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(235, 59);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Thoát chương trình";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Gray;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(10, 585);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(240, 10);
            this.guna2Separator1.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.CheckedState.FillColor = System.Drawing.Color.Red;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnLogout.FillColor2 = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnLogout.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageSize = new System.Drawing.Size(35, 35);
            this.btnLogout.Location = new System.Drawing.Point(5, 658);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(245, 45);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseTransparentBackground = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.Animated = true;
            this.btnSanPham.BackColor = System.Drawing.Color.Transparent;
            this.btnSanPham.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanPham.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnSanPham.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSanPham.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSanPham.FillColor = System.Drawing.Color.Empty;
            this.btnSanPham.FillColor2 = System.Drawing.Color.Empty;
            this.btnSanPham.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSanPham.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnSanPham.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnSanPham.Location = new System.Drawing.Point(5, 277);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(241, 45);
            this.btnSanPham.TabIndex = 2;
            this.btnSanPham.Text = "Sản Phẩm";
            this.btnSanPham.UseTransparentBackground = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Animated = true;
            this.btnKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btnKhachHang.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhachHang.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnKhachHang.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKhachHang.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.btnKhachHang.FillColor = System.Drawing.Color.Empty;
            this.btnKhachHang.FillColor2 = System.Drawing.Color.Empty;
            this.btnKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnKhachHang.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnKhachHang.Location = new System.Drawing.Point(3, 337);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(241, 45);
            this.btnKhachHang.TabIndex = 2;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.UseTransparentBackground = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Animated = true;
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btnOrder.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrder.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.btnOrder.FillColor = System.Drawing.Color.Empty;
            this.btnOrder.FillColor2 = System.Drawing.Color.Empty;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnOrder.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnOrder.Location = new System.Drawing.Point(3, 216);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(241, 45);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Hoá Đơn";
            this.btnOrder.UseTransparentBackground = true;
            this.btnOrder.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lbl1.ForeColor = System.Drawing.Color.Yellow;
            this.lbl1.Location = new System.Drawing.Point(12, 163);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(226, 30);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "QUẢN LÝ CỬA HÀNG";
            // 
            // pcbIcon
            // 
            this.pcbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pcbIcon.Image")));
            this.pcbIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcbIcon.InitialImage")));
            this.pcbIcon.Location = new System.Drawing.Point(26, 12);
            this.pcbIcon.Name = "pcbIcon";
            this.pcbIcon.Size = new System.Drawing.Size(189, 129);
            this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIcon.TabIndex = 2;
            this.pcbIcon.TabStop = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblTitle.Location = new System.Drawing.Point(256, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(950, 50);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "CHƯƠNG TRÌNH QUẢN LÝ CỬA HÀNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.lblTitle;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.pnlMainContent.Location = new System.Drawing.Point(256, 46);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(950, 679);
            this.pnlMainContent.TabIndex = 4;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1145, 10);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox1.TabIndex = 5;
            // 
            // btnOutStockAlert
            // 
            this.btnOutStockAlert.Animated = true;
            this.btnOutStockAlert.BackColor = System.Drawing.Color.Transparent;
            this.btnOutStockAlert.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnOutStockAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOutStockAlert.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOutStockAlert.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.btnOutStockAlert.FillColor = System.Drawing.Color.Empty;
            this.btnOutStockAlert.FillColor2 = System.Drawing.Color.Empty;
            this.btnOutStockAlert.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOutStockAlert.ForeColor = System.Drawing.Color.White;
            this.btnOutStockAlert.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnOutStockAlert.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnOutStockAlert.Image = ((System.Drawing.Image)(resources.GetObject("btnOutStockAlert.Image")));
            this.btnOutStockAlert.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOutStockAlert.ImageSize = new System.Drawing.Size(35, 35);
            this.btnOutStockAlert.Location = new System.Drawing.Point(9, 520);
            this.btnOutStockAlert.Name = "btnOutStockAlert";
            this.btnOutStockAlert.Size = new System.Drawing.Size(241, 45);
            this.btnOutStockAlert.TabIndex = 4;
            this.btnOutStockAlert.Text = "SP Hết Hàng";
            this.btnOutStockAlert.UseTransparentBackground = true;
            this.btnOutStockAlert.Click += new System.EventHandler(this.btnOutStockAlert_Click);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 725);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormManager_Load);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnMenu;
        private Guna.UI2.WinForms.Guna2GradientButton btnTaiKhoan;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogout;
        private Guna.UI2.WinForms.Guna2GradientButton btnSanPham;
        private Guna.UI2.WinForms.Guna2GradientButton btnKhachHang;
        private Guna.UI2.WinForms.Guna2GradientButton btnOrder;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox pcbIcon;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel pnlMainContent;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnImportProduct;
        private Guna.UI2.WinForms.Guna2GradientButton btnOutStockAlert;
    }
}

