using MiniMarket.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMarket.GUI.CONTROLS
{
    public partial class ProductItem : UserControl
    {
        private Product _product;

        public ProductItem()
        {
            InitializeComponent();
        }

        public Product Product { get => _product; 
            set {
                
                if (value == null)
                    return;

                _product = value;

                picImage.Image = Image.FromFile("Images/default.png");

                if (!string.IsNullOrEmpty(_product.Image))
                {
                    if (File.Exists("Images/" + _product.Image))
                    {
                        picImage.Image = Image.FromFile("Images/" + _product.Image);
                    }
                }

                lblProductName.Text = _product.ProductName;
                lblQuantity.Text = _product.Quantity.ToString();
                lblSalePrice.Text = string.Format("{0:#,###} vnđ", _product.SalePrice);
                lblUnitName.Text = _product.UnitName;
            } 
        }

        public delegate void ProductSelectDelegate(Product product);
        public event ProductSelectDelegate ProductSelectHandler;
        
        private void ProductItem_Load(object sender, EventArgs e)
        {

        }

        private void ProductItem_DoubleClick(object sender, EventArgs e)
        {
            if (Product == null)
                return;

            if (ProductSelectHandler != null)
            {
                ProductSelectHandler(Product);
            }
        }

        private void picImage_DoubleClick(object sender, EventArgs e)
        {
            ProductItem_DoubleClick(sender, e);
        }

        private void lblProductName_DoubleClick(object sender, EventArgs e)
        {
            ProductItem_DoubleClick(sender, e);
        }

        private void ProductItem_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ActiveCaption;   
        }

        private void ProductItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }
    }
}
