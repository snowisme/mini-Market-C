namespace MiniMarket.GUI
{
    partial class FormImportManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.gridImport = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowAll = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDisplayOutSTock = new Guna.UI2.WinForms.Guna2CheckBox();
            this.dtImportDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gridImportDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboProduct = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemCT = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoaCT = new Guna.UI2.WinForms.Guna2GradientButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridImport)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridImportDetail)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(12, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 64);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
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
            this.btnLuu.Location = new System.Drawing.Point(723, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(169, 45);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseTransparentBackground = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(548, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(169, 45);
            this.btnXoa.TabIndex = 6;
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
            this.btnThem.Location = new System.Drawing.Point(369, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(169, 45);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseTransparentBackground = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(494, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Nhập Hàng :";
            // 
            // gridImport
            // 
            this.gridImport.AllowUserToAddRows = false;
            this.gridImport.AllowUserToDeleteRows = false;
            this.gridImport.AllowUserToResizeColumns = false;
            this.gridImport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.gridImport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridImport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.gridImport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridImport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.gridImport.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridImport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridImport.ColumnHeadersHeight = 25;
            this.gridImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.gridImport.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridImport.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridImport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.gridImport.Location = new System.Drawing.Point(12, 442);
            this.gridImport.Name = "gridImport";
            this.gridImport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridImport.RowHeadersVisible = false;
            this.gridImport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.gridImport.RowTemplate.DividerHeight = 2;
            this.gridImport.RowTemplate.Height = 30;
            this.gridImport.Size = new System.Drawing.Size(907, 203);
            this.gridImport.TabIndex = 33;
            this.gridImport.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.gridImport.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.gridImport.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridImport.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridImport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridImport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridImport.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridImport.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.gridImport.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.gridImport.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridImport.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridImport.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridImport.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridImport.ThemeStyle.HeaderStyle.Height = 25;
            this.gridImport.ThemeStyle.ReadOnly = false;
            this.gridImport.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.gridImport.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.gridImport.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.gridImport.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridImport.ThemeStyle.RowsStyle.Height = 30;
            this.gridImport.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.gridImport.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridImport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridImport_CellClick);
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Username";
            this.Column3.HeaderText = "Người Nhập";
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ImportDate";
            this.Column4.HeaderText = "Ngày Nhập";
            this.Column4.Name = "Column4";
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
            this.btnShowAll.Size = new System.Drawing.Size(169, 43);
            this.btnShowAll.TabIndex = 20;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseTransparentBackground = true;
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.groupBox3.Controls.Add(this.btnShowAll);
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Location = new System.Drawing.Point(12, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(907, 69);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.groupBox1.Controls.Add(this.chkDisplayOutSTock);
            this.groupBox1.Controls.Add(this.dtImportDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 63);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // chkDisplayOutSTock
            // 
            this.chkDisplayOutSTock.AutoSize = true;
            this.chkDisplayOutSTock.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkDisplayOutSTock.CheckedState.BorderRadius = 0;
            this.chkDisplayOutSTock.CheckedState.BorderThickness = 0;
            this.chkDisplayOutSTock.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkDisplayOutSTock.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.chkDisplayOutSTock.Location = new System.Drawing.Point(23, 19);
            this.chkDisplayOutSTock.Name = "chkDisplayOutSTock";
            this.chkDisplayOutSTock.Size = new System.Drawing.Size(246, 29);
            this.chkDisplayOutSTock.TabIndex = 9;
            this.chkDisplayOutSTock.Text = "Hiển thị mặt hàng đã hết";
            this.chkDisplayOutSTock.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkDisplayOutSTock.UncheckedState.BorderRadius = 0;
            this.chkDisplayOutSTock.UncheckedState.BorderThickness = 0;
            this.chkDisplayOutSTock.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkDisplayOutSTock.CheckedChanged += new System.EventHandler(this.chkDisplayOutSTock_CheckedChanged);
            // 
            // dtImportDate
            // 
            this.dtImportDate.Checked = true;
            this.dtImportDate.CustomFormat = "dd/MM/yyyy";
            this.dtImportDate.FillColor = System.Drawing.Color.White;
            this.dtImportDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtImportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtImportDate.Location = new System.Drawing.Point(684, 19);
            this.dtImportDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtImportDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtImportDate.Name = "dtImportDate";
            this.dtImportDate.Size = new System.Drawing.Size(208, 32);
            this.dtImportDate.TabIndex = 8;
            this.dtImportDate.Value = new System.DateTime(2024, 3, 7, 19, 0, 37, 422);
            // 
            // gridImportDetail
            // 
            this.gridImportDetail.AllowUserToAddRows = false;
            this.gridImportDetail.AllowUserToDeleteRows = false;
            this.gridImportDetail.AllowUserToResizeColumns = false;
            this.gridImportDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.gridImportDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridImportDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.gridImportDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridImportDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.gridImportDetail.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridImportDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridImportDetail.ColumnHeadersHeight = 25;
            this.gridImportDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.gridImportDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 13F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridImportDetail.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridImportDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.gridImportDetail.Location = new System.Drawing.Point(12, 151);
            this.gridImportDetail.Name = "gridImportDetail";
            this.gridImportDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridImportDetail.RowHeadersVisible = false;
            this.gridImportDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.gridImportDetail.RowTemplate.DividerHeight = 2;
            this.gridImportDetail.RowTemplate.Height = 30;
            this.gridImportDetail.Size = new System.Drawing.Size(907, 140);
            this.gridImportDetail.TabIndex = 34;
            this.gridImportDetail.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.gridImportDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.gridImportDetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridImportDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridImportDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridImportDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridImportDetail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridImportDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.gridImportDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.gridImportDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridImportDetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridImportDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridImportDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridImportDetail.ThemeStyle.HeaderStyle.Height = 25;
            this.gridImportDetail.ThemeStyle.ReadOnly = false;
            this.gridImportDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.gridImportDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.gridImportDetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.gridImportDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridImportDetail.ThemeStyle.RowsStyle.Height = 30;
            this.gridImportDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.gridImportDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridImportDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridImportDetail_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ProductName";
            this.Column1.FillWeight = 194.9239F;
            this.Column1.HeaderText = "Tên SP";
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Quantity";
            this.Column2.FillWeight = 5.076141F;
            this.Column2.HeaderText = "Số Lượng";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.groupBox4.Controls.Add(this.cboProduct);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtQuantity);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btnThemCT);
            this.groupBox4.Controls.Add(this.btnXoaCT);
            this.groupBox4.Location = new System.Drawing.Point(12, 81);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(907, 64);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            // 
            // cboProduct
            // 
            this.cboProduct.BackColor = System.Drawing.Color.Transparent;
            this.cboProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduct.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboProduct.ItemHeight = 30;
            this.cboProduct.Location = new System.Drawing.Point(141, 16);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(300, 36);
            this.cboProduct.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(447, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "SL :";
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
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Location = new System.Drawing.Point(494, 18);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(193, 34);
            this.txtQuantity.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sản phẩm :";
            // 
            // btnThemCT
            // 
            this.btnThemCT.Animated = true;
            this.btnThemCT.BackColor = System.Drawing.Color.Transparent;
            this.btnThemCT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemCT.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThemCT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThemCT.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThemCT.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnThemCT.ForeColor = System.Drawing.Color.White;
            this.btnThemCT.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnThemCT.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnThemCT.Location = new System.Drawing.Point(713, 16);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(88, 36);
            this.btnThemCT.TabIndex = 3;
            this.btnThemCT.Text = "Thêm";
            this.btnThemCT.UseTransparentBackground = true;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Animated = true;
            this.btnXoaCT.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaCT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaCT.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoaCT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoaCT.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoaCT.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnXoaCT.ForeColor = System.Drawing.Color.White;
            this.btnXoaCT.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnXoaCT.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnXoaCT.Location = new System.Drawing.Point(819, 17);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(73, 36);
            this.btnXoaCT.TabIndex = 3;
            this.btnXoaCT.Text = "Xóa";
            this.btnXoaCT.UseTransparentBackground = true;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // FormImportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(930, 652);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gridImport);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridImportDetail);
            this.Name = "FormImportManager";
            this.Text = "FormImportManager";
            this.Load += new System.EventHandler(this.FormImportManager_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridImport)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridImportDetail)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView gridImport;
        private Guna.UI2.WinForms.Guna2GradientButton btnShowAll;
        private Guna.UI2.WinForms.Guna2GradientButton btnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtImportDate;
        private Guna.UI2.WinForms.Guna2DataGridView gridImportDetail;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoaCT;
        private Guna.UI2.WinForms.Guna2ComboBox cboProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private Guna.UI2.WinForms.Guna2GradientButton btnThemCT;
        private Guna.UI2.WinForms.Guna2GradientButton btnLuu;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2CheckBox chkDisplayOutSTock;
    }
}