namespace MiniMarket.GUI
{
    partial class FormCustomerManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridCustomer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBoQua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLuu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoNu = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoNam = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCustomername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCustomer
            // 
            this.gridCustomer.AllowUserToAddRows = false;
            this.gridCustomer.AllowUserToDeleteRows = false;
            this.gridCustomer.AllowUserToResizeColumns = false;
            this.gridCustomer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.gridCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.gridCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.gridCustomer.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridCustomer.ColumnHeadersHeight = 25;
            this.gridCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.gridCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.gridCustomer.Location = new System.Drawing.Point(12, 392);
            this.gridCustomer.Name = "gridCustomer";
            this.gridCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridCustomer.RowHeadersVisible = false;
            this.gridCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.gridCustomer.RowTemplate.DividerHeight = 2;
            this.gridCustomer.RowTemplate.Height = 30;
            this.gridCustomer.Size = new System.Drawing.Size(907, 253);
            this.gridCustomer.TabIndex = 25;
            this.gridCustomer.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.gridCustomer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.gridCustomer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridCustomer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridCustomer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridCustomer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridCustomer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridCustomer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.gridCustomer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.gridCustomer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridCustomer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridCustomer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridCustomer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridCustomer.ThemeStyle.HeaderStyle.Height = 25;
            this.gridCustomer.ThemeStyle.ReadOnly = false;
            this.gridCustomer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.gridCustomer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.gridCustomer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.gridCustomer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridCustomer.ThemeStyle.RowsStyle.Height = 30;
            this.gridCustomer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.gridCustomer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridCustomer.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCustomer_CellEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.groupBox3.Controls.Add(this.btnShowAll);
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Location = new System.Drawing.Point(12, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(907, 69);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.groupBox2.Controls.Add(this.btnBoQua);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(12, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 64);
            this.groupBox2.TabIndex = 24;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.groupBox1.Controls.Add(this.rdoNu);
            this.groupBox1.Controls.Add(this.rdoNam);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtCustomername);
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
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chỉnh Sửa";
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoNu.CheckedState.BorderThickness = 0;
            this.rdoNu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoNu.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoNu.CheckedState.InnerOffset = -4;
            this.rdoNu.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdoNu.Location = new System.Drawing.Point(302, 86);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(57, 29);
            this.rdoNu.TabIndex = 7;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoNu.UncheckedState.BorderThickness = 2;
            this.rdoNu.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoNu.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Checked = true;
            this.rdoNam.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoNam.CheckedState.BorderThickness = 0;
            this.rdoNam.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoNam.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoNam.CheckedState.InnerOffset = -4;
            this.rdoNam.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdoNam.Location = new System.Drawing.Point(158, 86);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(72, 29);
            this.rdoNam.TabIndex = 7;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoNam.UncheckedState.BorderThickness = 2;
            this.rdoNam.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoNam.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(578, 31);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(302, 180);
            this.txtAddress.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(158, 179);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(300, 32);
            this.txtPassword.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(158, 131);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(300, 32);
            this.txtPhone.TabIndex = 1;
            // 
            // txtCustomername
            // 
            this.txtCustomername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomername.DefaultText = "";
            this.txtCustomername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCustomername.ForeColor = System.Drawing.Color.Black;
            this.txtCustomername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomername.Location = new System.Drawing.Point(158, 28);
            this.txtCustomername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomername.Name = "txtCustomername";
            this.txtCustomername.PasswordChar = '\0';
            this.txtCustomername.PlaceholderText = "";
            this.txtCustomername.SelectedText = "";
            this.txtCustomername.Size = new System.Drawing.Size(300, 32);
            this.txtCustomername.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mật Khẩu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giới Tính :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số ĐT :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên KH :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(476, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa Chỉ :";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CustomerId";
            this.Column1.HeaderText = "Mã KH";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CustomerName";
            this.Column2.HeaderText = "Tên KH";
            this.Column2.Name = "Column2";
            this.Column2.Width = 350;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Gender";
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Phone";
            this.Column4.HeaderText = "Số ĐT";
            this.Column4.Name = "Column4";
            this.Column4.Width = 151;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Password";
            this.Column5.HeaderText = "Mật Khẩu";
            this.Column5.Name = "Column5";
            this.Column5.Width = 151;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Address";
            this.Column6.HeaderText = "Địa Chỉ";
            this.Column6.Name = "Column6";
            this.Column6.Width = 250;
            // 
            // FormCustomerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(937, 658);
            this.Controls.Add(this.gridCustomer);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCustomerManager";
            this.Text = "FormCustomerManager";
            this.Load += new System.EventHandler(this.FormCustomerManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView gridCustomer;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2GradientButton btnShowAll;
        private Guna.UI2.WinForms.Guna2GradientButton btnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2GradientButton btnBoQua;
        private Guna.UI2.WinForms.Guna2GradientButton btnLuu;
        private Guna.UI2.WinForms.Guna2GradientButton btnSua;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2RadioButton rdoNu;
        private Guna.UI2.WinForms.Guna2RadioButton rdoNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}