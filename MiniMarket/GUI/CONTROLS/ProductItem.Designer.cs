namespace MiniMarket.GUI.CONTROLS
{
    partial class ProductItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductItem));
            this.picImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblProductName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSalePrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblQuantity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUnitName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.Image = ((System.Drawing.Image)(resources.GetObject("picImage.Image")));
            this.picImage.ImageRotate = 0F;
            this.picImage.Location = new System.Drawing.Point(3, 1);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(44, 42);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            this.picImage.DoubleClick += new System.EventHandler(this.picImage_DoubleClick);
            // 
            // lblProductName
            // 
            this.lblProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductName.AutoSize = false;
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(62, 14);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(131, 22);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Tên Sản Phẩm";
            this.lblProductName.DoubleClick += new System.EventHandler(this.lblProductName_DoubleClick);
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = false;
            this.lblSalePrice.BackColor = System.Drawing.Color.Transparent;
            this.lblSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalePrice.ForeColor = System.Drawing.Color.Red;
            this.lblSalePrice.Location = new System.Drawing.Point(199, 14);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(129, 22);
            this.lblSalePrice.TabIndex = 2;
            this.lblSalePrice.Text = "200,000 đ";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantity.AutoSize = false;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblQuantity.Location = new System.Drawing.Point(334, 14);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(59, 22);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "20";
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = false;
            this.lblUnitName.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblUnitName.Location = new System.Drawing.Point(412, 14);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(74, 22);
            this.lblUnitName.TabIndex = 2;
            this.lblUnitName.Text = "Kg";
            // 
            // ProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblUnitName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblSalePrice);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.picImage);
            this.Name = "ProductItem";
            this.Size = new System.Drawing.Size(489, 42);
            this.Load += new System.EventHandler(this.ProductItem_Load);
            this.DoubleClick += new System.EventHandler(this.ProductItem_DoubleClick);
            this.MouseLeave += new System.EventHandler(this.ProductItem_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ProductItem_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picImage;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProductName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSalePrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuantity;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUnitName;
    }
}
