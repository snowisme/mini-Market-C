using MiniMarket.DAL;
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

namespace MiniMarket.GUI
{
    public partial class FormProductManager : Form
    {
        public FormProductManager()
        {
            InitializeComponent();
        }

        ProductDAL _productDAL = new ProductDAL();
        UnitDAL _unitDAL = new UnitDAL();
        BindingSource _src = new BindingSource();
        private string fileAddress;
        private string fileSavePath;

        private void FormProductManager_Load(object sender, EventArgs e)
        {
            LoadComboUnit();
            gridProduct.AutoGenerateColumns = false;
            gridProduct.DataSource = _src;
            LoadGridProduct();
        }

        private void LoadGridProduct()
        {
            _src.DataSource = _productDAL.GetAll();
            _src.ResetBindings(true);
        }

        private void LoadComboUnit()
        {
            cboUnit.DataSource = _unitDAL.GetAll();
            cboUnit.ValueMember = "UnitId";
            cboUnit.DisplayMember = "UnitName";
            cboUnit.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "";
            cboUnit.SelectedIndex = 0;
            txtQuantity.Text = "0";
            txtSalePrice.Text = "0";
            txtImage.Text = "";
            pbProductImage.Image = null;
        }

        private Product getCurrentProduct()
        {
            if (gridProduct.CurrentRow == null || gridProduct.CurrentRow.IsNewRow)
                return null;

            var obj = gridProduct.CurrentRow.DataBoundItem as Product;

            return obj;
        }

        private void gridProduct_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var obj = getCurrentProduct();
            
            if (obj != null)
                Display(obj);
        }

        private void Display(Product obj)
        {
            txtProductName.Text = obj.ProductName;
            cboUnit.SelectedValue = obj.UnitId;
            txtQuantity.Text = obj.Quantity.ToString();
            txtSalePrice.Text = string.Format("{0:#,###}", obj.SalePrice);
            txtImage.Text = obj.Image;
            if (File.Exists("Images/" + obj.Image))
                pbProductImage.Image = Image.FromFile("Images/" + obj.Image);
            else pbProductImage.Image = null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obj = getCurrentProduct();

            if (obj == null)
            {
                MessageBox.Show("Không có sản phẩm nào được chọn !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show(string.Format("Bạn muốn xoá sản phẩm [{0}] ? ", obj.ProductName)
                , "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            var ret = _productDAL.Delete(obj.ProductId);

            if (ret > 0)
            {
                MessageBox.Show("Xoá sản phẩm thành công !",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadGridProduct();
                return;
            }

            MessageBox.Show("Xoá sản phẩm không thành công !",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = getCurrentProduct();

            if (obj == null)
            {
                MessageBox.Show("Không có sản phẩm nào được chọn !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Tên sản phẩm không được để trống !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            obj.ProductName = txtProductName.Text;

            if (cboUnit.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn đơn vị sản phẩm !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            obj.UnitId = (cboUnit.SelectedItem as Unit)?.UnitId ?? 0;
            obj.UnitName = (cboUnit.SelectedItem as Unit)?.UnitName;
            
            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Số lượng sản phẩm phải thuộc kiểu số !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            obj.Quantity = quantity;

            if (!decimal.TryParse(txtSalePrice.Text, out decimal salePrice))
            {
                MessageBox.Show("Giá bán sản phẩm phải thuộc kiểu số !",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    

            obj.SalePrice = salePrice;
            obj.Image = txtImage.Text;

            var ret = _productDAL.Update(obj);

            if (ret > 0)
            {
                CopyProductImage();

                MessageBox.Show("Thay đổi thông tin sản phẩm thành công !",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadGridProduct();
                return;
            }

            MessageBox.Show("Thay đổi thông tin sản phẩm không thành công !",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CopyProductImage()
        {
            if (File.Exists(fileAddress))
            {
                if (File.Exists(fileSavePath))
                    File.Delete(fileSavePath);

                File.Copy(fileAddress, fileSavePath);
                fileAddress = string.Empty;
                fileSavePath = string.Empty;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Product obj = new Product();

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Tên sản phẩm không được để trống !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

            obj.ProductName = txtProductName.Text;

            if (cboUnit.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn đơn vị sản phẩm !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

            obj.UnitId = (cboUnit.SelectedItem as Unit)?.UnitId ?? 0;
            obj.UnitName = (cboUnit.SelectedItem as Unit)?.UnitName;

            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Số lượng sản phẩm phải thuộc kiểu số !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            obj.Quantity = quantity;

            if (!decimal.TryParse(txtSalePrice.Text, out decimal salePrice))
            {
                MessageBox.Show("Giá bán sản phẩm phải thuộc kiểu số !",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            obj.SalePrice = salePrice;
            obj.Image = txtImage.Text;

            var ret = _productDAL.Insert(obj);

            if (ret > 0)
            {
                CopyProductImage();

                MessageBox.Show("Thêm mới sản phẩm thành công !",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                LoadGridProduct();

                return;
            }

            MessageBox.Show("Thêm mới sản phẩm không thành công !",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private Image cloneImage(string path)
        {
            Image result;
            using (Bitmap original = new Bitmap(path))
            {
                result = (Bitmap)original.Clone();

            };

            return result;
        }

        private void openImage()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|PNG(*.png)|*.png|GIF(.gif)|*.gif|All files(*.*)|*.*";
            open.FilterIndex = 2;
            open.Title = "Chọn ảnh minh họa cho sản phẩm";
            if (open.ShowDialog() == DialogResult.OK)
            {
                fileAddress = open.FileName;
                pbProductImage.Image = cloneImage(fileAddress);
                string fileName = Path.GetFileName(fileAddress);
                string saveDirectory = Application.StartupPath;
                fileSavePath = saveDirectory + @"\Images\" + fileName;
                txtImage.Text = fileName;
            }
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            openImage();
        }

        private void pbProductImage_Click(object sender, EventArgs e)
        {
            openImage();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchTerm = txtTimKiem.Text;
            
            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadGridProduct();
                return;
            }    

            List<Product> products = _productDAL.GetAll();
            products = products.Where(x => x.ProductName.ToLower().Contains(searchTerm.ToLower()))
                .ToList();
            _src.DataSource = products;
            _src.ResetBindings(true);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadGridProduct();
        }
    }
}
