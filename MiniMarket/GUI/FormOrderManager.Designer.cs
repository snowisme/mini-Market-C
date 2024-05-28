namespace MiniMarket.GUI
{
    partial class FormOrderManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridOrder = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCustomer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gridOrderDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dtOrderDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalPrice.DefaultText = "";
            this.txtTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.txtTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.Location = new System.Drawing.Point(170, 85);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.PlaceholderText = "";
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.Size = new System.Drawing.Size(300, 32);
            this.txtTotalPrice.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng Tiền :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(494, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Mua Hàng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khách Hàng :";
            // 
            // gridOrder
            // 
            this.gridOrder.AllowUserToAddRows = false;
            this.gridOrder.AllowUserToDeleteRows = false;
            this.gridOrder.AllowUserToResizeColumns = false;
            this.gridOrder.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.gridOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.gridOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.gridOrder.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridOrder.ColumnHeadersHeight = 25;
            this.gridOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.gridOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 13F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridOrder.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.gridOrder.Location = new System.Drawing.Point(12, 442);
            this.gridOrder.Name = "gridOrder";
            this.gridOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridOrder.RowHeadersVisible = false;
            this.gridOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.gridOrder.RowTemplate.DividerHeight = 2;
            this.gridOrder.RowTemplate.Height = 30;
            this.gridOrder.Size = new System.Drawing.Size(907, 203);
            this.gridOrder.TabIndex = 29;
            this.gridOrder.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.gridOrder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.gridOrder.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridOrder.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridOrder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.gridOrder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.gridOrder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridOrder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridOrder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridOrder.ThemeStyle.HeaderStyle.Height = 25;
            this.gridOrder.ThemeStyle.ReadOnly = false;
            this.gridOrder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.gridOrder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.gridOrder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.gridOrder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridOrder.ThemeStyle.RowsStyle.Height = 30;
            this.gridOrder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.gridOrder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridOrder_CellClick);
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
            this.btnXoa.Location = new System.Drawing.Point(723, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(169, 45);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseTransparentBackground = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Location = new System.Drawing.Point(12, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 64);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.groupBox3.Controls.Add(this.btnShowAll);
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Location = new System.Drawing.Point(12, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(907, 69);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.groupBox1.Controls.Add(this.dtOrderDate);
            this.groupBox1.Controls.Add(this.cboCustomer);
            this.groupBox1.Controls.Add(this.txtTotalPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 146);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chỉnh Sửa";
            // 
            // cboCustomer
            // 
            this.cboCustomer.BackColor = System.Drawing.Color.Transparent;
            this.cboCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboCustomer.ItemHeight = 30;
            this.cboCustomer.Location = new System.Drawing.Point(170, 24);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(300, 36);
            this.cboCustomer.TabIndex = 7;
            // 
            // gridOrderDetail
            // 
            this.gridOrderDetail.AllowUserToAddRows = false;
            this.gridOrderDetail.AllowUserToDeleteRows = false;
            this.gridOrderDetail.AllowUserToResizeColumns = false;
            this.gridOrderDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.gridOrderDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.gridOrderDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridOrderDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.gridOrderDetail.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridOrderDetail.ColumnHeadersHeight = 25;
            this.gridOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7});
            this.gridOrderDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 13F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridOrderDetail.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridOrderDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.gridOrderDetail.Location = new System.Drawing.Point(12, 173);
            this.gridOrderDetail.Name = "gridOrderDetail";
            this.gridOrderDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridOrderDetail.RowHeadersVisible = false;
            this.gridOrderDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.gridOrderDetail.RowTemplate.DividerHeight = 2;
            this.gridOrderDetail.RowTemplate.Height = 30;
            this.gridOrderDetail.Size = new System.Drawing.Size(907, 118);
            this.gridOrderDetail.TabIndex = 29;
            this.gridOrderDetail.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.gridOrderDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.gridOrderDetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridOrderDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridOrderDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridOrderDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridOrderDetail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridOrderDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.gridOrderDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.gridOrderDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridOrderDetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridOrderDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridOrderDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridOrderDetail.ThemeStyle.HeaderStyle.Height = 25;
            this.gridOrderDetail.ThemeStyle.ReadOnly = false;
            this.gridOrderDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.gridOrderDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.gridOrderDetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.gridOrderDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridOrderDetail.ThemeStyle.RowsStyle.Height = 30;
            this.gridOrderDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.gridOrderDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.Checked = true;
            this.dtOrderDate.CustomFormat = "dd/MM/yyyy";
            this.dtOrderDate.FillColor = System.Drawing.Color.White;
            this.dtOrderDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOrderDate.Location = new System.Drawing.Point(684, 27);
            this.dtOrderDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtOrderDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtOrderDate.Name = "dtOrderDate";
            this.dtOrderDate.Size = new System.Drawing.Size(218, 32);
            this.dtOrderDate.TabIndex = 8;
            this.dtOrderDate.Value = new System.DateTime(2024, 3, 7, 19, 0, 37, 422);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ProductName";
            this.Column5.HeaderText = "Tên SP";
            this.Column5.Name = "Column5";
            this.Column5.Width = 250;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Quantity";
            this.Column6.HeaderText = "Số Lượng";
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Price";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "#,###.##";
            this.Column7.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column7.HeaderText = "Đơn Giá";
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "OrderId";
            this.Column1.HeaderText = "Mã HĐ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "OrderDate";
            this.Column2.HeaderText = "Ngày Lập";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CustomerName";
            this.Column3.HeaderText = "Tên Khách Hàng";
            this.Column3.Name = "Column3";
            this.Column3.Width = 350;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TotalPrice";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,###.##";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "Tổng Tiền";
            this.Column4.Name = "Column4";
            // 
            // FormOrderManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(928, 653);
            this.Controls.Add(this.gridOrderDetail);
            this.Controls.Add(this.gridOrder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormOrderManager";
            this.Text = "FormOrderManager";
            this.Load += new System.EventHandler(this.FormOrderManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtTotalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView gridOrder;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2GradientButton btnShowAll;
        private Guna.UI2.WinForms.Guna2GradientButton btnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cboCustomer;
        private Guna.UI2.WinForms.Guna2DataGridView gridOrderDetail;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}