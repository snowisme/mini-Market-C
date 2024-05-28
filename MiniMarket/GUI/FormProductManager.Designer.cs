namespace MiniMarket.GUI
{
    partial class FormProductManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenImage = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.txtSalePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBoQua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLuu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnShowAll = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gridProduct = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboUnit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.groupBox1.Controls.Add(this.cboUnit);
            this.groupBox1.Controls.Add(this.btnOpenImage);
            this.groupBox1.Controls.Add(this.txtImage);
            this.groupBox1.Controls.Add(this.pbProductImage);
            this.groupBox1.Controls.Add(this.txtSalePrice);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 229);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chỉnh Sửa";
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Animated = true;
            this.btnOpenImage.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenImage.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOpenImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOpenImage.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOpenImage.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnOpenImage.ForeColor = System.Drawing.Color.White;
            this.btnOpenImage.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnOpenImage.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnOpenImage.Location = new System.Drawing.Point(580, 75);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(159, 36);
            this.btnOpenImage.TabIndex = 4;
            this.btnOpenImage.Text = "Mở hình";
            this.btnOpenImage.UseTransparentBackground = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // txtImage
            // 
            this.txtImage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImage.Location = new System.Drawing.Point(580, 28);
            this.txtImage.Multiline = true;
            this.txtImage.Name = "txtImage";
            this.txtImage.ReadOnly = true;
            this.txtImage.Size = new System.Drawing.Size(159, 32);
            this.txtImage.TabIndex = 5;
            // 
            // pbProductImage
            // 
            this.pbProductImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProductImage.Location = new System.Drawing.Point(758, 19);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(138, 133);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProductImage.TabIndex = 4;
            this.pbProductImage.TabStop = false;
            this.pbProductImage.Click += new System.EventHandler(this.pbProductImage_Click);
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalePrice.DefaultText = "";
            this.txtSalePrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSalePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSalePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalePrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalePrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalePrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSalePrice.ForeColor = System.Drawing.Color.Black;
            this.txtSalePrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalePrice.Location = new System.Drawing.Point(158, 179);
            this.txtSalePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.PasswordChar = '\0';
            this.txtSalePrice.PlaceholderText = "";
            this.txtSalePrice.SelectedText = "";
            this.txtSalePrice.Size = new System.Drawing.Size(300, 32);
            this.txtSalePrice.TabIndex = 1;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Location = new System.Drawing.Point(158, 131);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(300, 32);
            this.txtQuantity.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.DefaultText = "";
            this.txtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtProductName.ForeColor = System.Drawing.Color.Black;
            this.txtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Location = new System.Drawing.Point(158, 28);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PlaceholderText = "";
            this.txtProductName.SelectedText = "";
            this.txtProductName.Size = new System.Drawing.Size(300, 32);
            this.txtProductName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đơn Giá Bán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(476, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hình Ảnh:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBoQua);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(12, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 64);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // btnBoQua
            // 
            this.btnBoQua.Animated = true;
            this.btnBoQua.BackColor = System.Drawing.Color.Transparent;
            this.btnBoQua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoQua.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBoQua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBoQua.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBoQua.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnBoQua.ForeColor = System.Drawing.Color.White;
            this.btnBoQua.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnBoQua.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnBoQua.Location = new System.Drawing.Point(727, 13);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(169, 45);
            this.btnBoQua.TabIndex = 3;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.UseTransparentBackground = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Animated = true;
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLuu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnLuu.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnLuu.Location = new System.Drawing.Point(548, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(169, 45);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseTransparentBackground = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Animated = true;
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSua.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnSua.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnSua.Location = new System.Drawing.Point(369, 13);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(169, 45);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseTransparentBackground = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Animated = true;
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnXoa.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnXoa.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnXoa.Location = new System.Drawing.Point(190, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(169, 45);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseTransparentBackground = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Animated = true;
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThem.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnThem.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnThem.Location = new System.Drawing.Point(11, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(169, 45);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseTransparentBackground = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnShowAll);
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Location = new System.Drawing.Point(12, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(907, 69);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Location = new System.Drawing.Point(11, 15);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(527, 43);
            this.txtTimKiem.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Animated = true;
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTimKiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTimKiem.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnTimKiem.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnTimKiem.Location = new System.Drawing.Point(548, 15);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(169, 43);
            this.btnTimKiem.TabIndex = 19;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseTransparentBackground = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Animated = true;
            this.btnShowAll.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnShowAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnShowAll.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnShowAll.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnShowAll.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnShowAll.Location = new System.Drawing.Point(723, 15);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(180, 43);
            this.btnShowAll.TabIndex = 20;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseTransparentBackground = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // gridProduct
            // 
            this.gridProduct.AllowUserToAddRows = false;
            this.gridProduct.AllowUserToDeleteRows = false;
            this.gridProduct.AllowUserToResizeColumns = false;
            this.gridProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.gridProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.gridProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.gridProduct.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridProduct.ColumnHeadersHeight = 25;
            this.gridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gridProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 13F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProduct.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.gridProduct.Location = new System.Drawing.Point(12, 392);
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridProduct.RowHeadersVisible = false;
            this.gridProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridProduct.RowTemplate.DividerHeight = 2;
            this.gridProduct.RowTemplate.Height = 30;
            this.gridProduct.Size = new System.Drawing.Size(907, 253);
            this.gridProduct.TabIndex = 21;
            this.gridProduct.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.gridProduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.gridProduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridProduct.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridProduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.gridProduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.gridProduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridProduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridProduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridProduct.ThemeStyle.HeaderStyle.Height = 25;
            this.gridProduct.ThemeStyle.ReadOnly = false;
            this.gridProduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.gridProduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.gridProduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.gridProduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridProduct.ThemeStyle.RowsStyle.Height = 30;
            this.gridProduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.gridProduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridProduct.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProduct_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn Vị:";
            // 
            // cboUnit
            // 
            this.cboUnit.BackColor = System.Drawing.Color.Transparent;
            this.cboUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboUnit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboUnit.ItemHeight = 30;
            this.cboUnit.Location = new System.Drawing.Point(158, 75);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(300, 36);
            this.cboUnit.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ProductId";
            this.Column1.FillWeight = 9.283787F;
            this.Column1.HeaderText = "Mã SP";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ProductName";
            this.Column2.FillWeight = 107.2545F;
            this.Column2.HeaderText = "Tên SP";
            this.Column2.Name = "Column2";
            this.Column2.Width = 450;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "UnitName";
            this.Column3.FillWeight = 380.7107F;
            this.Column3.HeaderText = "ĐVT";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Quantity";
            this.Column4.FillWeight = 0.5299553F;
            this.Column4.HeaderText = "Số Lượng";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SalePrice";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,###.##";
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.FillWeight = 2.221091F;
            this.Column5.HeaderText = "Giá Bán";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // FormProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(935, 657);
            this.Controls.Add(this.gridProduct);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormProductManager";
            this.Text = "FormProductManager";
            this.Load += new System.EventHandler(this.FormProductManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnOpenImage;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.PictureBox pbProductImage;
        private Guna.UI2.WinForms.Guna2TextBox txtSalePrice;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtProductName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2GradientButton btnBoQua;
        private Guna.UI2.WinForms.Guna2GradientButton btnLuu;
        private Guna.UI2.WinForms.Guna2GradientButton btnSua;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2GradientButton btnShowAll;
        private Guna.UI2.WinForms.Guna2GradientButton btnTimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView gridProduct;
        private Guna.UI2.WinForms.Guna2ComboBox cboUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}