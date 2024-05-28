using MiniMarket.DAL;
using MiniMarket.DTO;
using MiniMarket.GUI.CONTROLS;
using MiniMarket.PATTERN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMarket.GUI
{
    public partial class FormPOScreen : Form
    {
        public FormPOScreen()
        {
            InitializeComponent();
        }

        public FormPOScreen(Customer customer)
            : this()
        {
            _customer = customer;
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Khởi tạo Observer để lắng nghe các thay đổi trạng thái của Subject
        ProductQuantityChangeNotifyForCustomerObserver productChangeObserver;

        ProductDAL _productDAL = new ProductDAL();

        private void FormPOScreen_Load(object sender, EventArgs e)
        {
            productChangeObserver = new ProductQuantityChangeNotifyForCustomerObserver(_customer.CustomerId, Program.ProductQuantityChangeSubject);
            productChangeObserver.ProductInStockHandler += ProductChangeObserver_ProductInStockHandler;
            gridOrderDetail.AllowUserToAddRows = false;
            gridOrderDetail.AutoGenerateColumns = false;
            gridOrderDetail.DataSource = _bindingSource;
            LoadGridData();
            LoadProducts();
            LoadCustomerInfo();
            // Kiểm tra hàng trong wishlist có số lượng tồn hay không
            LoadWishlistAlert();
        }

        private void ProductChangeObserver_ProductInStockHandler()
        {
            LoadProducts();
        }

        private void LoadWishlistAlert()
        {
            List<Product> products = _productDAL.GetAllProductInWishList(_customer.CustomerId);
            List<Product> avaiableProduct = products.Where(x => x.Quantity > 0)
                .ToList();
            
            // Nếu không có sản phẩm nào có tồn lớn hơn 0
            if (avaiableProduct.Count <= 0)
                return;

            // Nếu có tồn lớn hơn 0 => sản phẩm đã có hàng trở lại
            // Hiển thị thông báo cho người dùng đã observer
            Program.ProductQuantityChangeSubject
                .SetNotifyMessage("Các sản phẩm trong danh sách yêu thích của bạn đã có hàng trở lại !"
                , SubjectForType.Customer);

            foreach (var product in avaiableProduct)
            {
                _currentSelectedProduct = product;
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.ProductId = product.ProductId;
                orderDetail.ProductName = product.ProductName;
                orderDetail.Quantity = 1;
                orderDetail.Price = product.SalePrice;
                AddToOrderList(orderDetail);
            } 
        }

        private void LoadGridData()
        {
            _bindingSource.DataSource = _orderDetails;
            _bindingSource.ResetBindings(true);
            CalculateSumTotal();
        }

        private void LoadCustomerInfo()
        {
            if (_customer == null)
                return;

            txtCustomerName.Text = _customer.CustomerName;
            txtPhone.Text = _customer.Phone;
            txtAddress.Text = _customer.Address;
        }

        private void LoadProducts(string filter = "")
        {
            panelProducts.Controls.Clear();

            List<Product> products = new List<Product>();

            if (string.IsNullOrEmpty(filter))
                products = _productDAL.GetAll();
            else
                products = _productDAL.SearchByName(filter);


            foreach (var product in products)
            {
                ProductItem item = new ProductItem();
                item.Name = "product_" + product.ProductId.ToString();
                item.ProductSelectHandler += Item_ProductSelectHandler;
                panelProducts.Controls.Add(item);
                item.Product = product;
            }

            txtProductName.Text = "";
            txtQuantity.Text = "";
        }

        private Product _currentSelectedProduct;
        private readonly Customer _customer;
        private WishListDAL _wishListDAL = new WishListDAL();
        private void Item_ProductSelectHandler(DTO.Product product)
        {
            _currentSelectedProduct = product;

            txtProductName.Text = product.ProductName;

            bool qtyPositive = product.Quantity > 0;

            if (!qtyPositive)
            {
                if (!_wishListDAL.Exits(_customer.CustomerId, _currentSelectedProduct.ProductId))
                {
                    var answer = MessageBox.Show("Sản phẩm này đang hết hàng ! Bạn có muốn thêm vào danh sách yêu thích ?"
                    , "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (answer == DialogResult.Yes)
                    {
                        Wishlist wishlist = new Wishlist();
                        wishlist.CustomerId = _customer.CustomerId;
                        wishlist.ProductId = _currentSelectedProduct.ProductId;
                        int result = _wishListDAL.Insert(wishlist);

                        if (result > 0)
                        {
                            MessageBox.Show("Đã thêm sản phẩm được chọn vào danh sách yêu thích !"
                                , "Thông báoo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            txtQuantity.Text = qtyPositive ? "1" : "";
            txtQuantity.Enabled = qtyPositive ? true : false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProducts(txtSearchTerm.Text);
        }

        List<OrderDetail> _orderDetails = new List<OrderDetail>();
        BindingSource _bindingSource = new BindingSource();

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (_currentSelectedProduct == null)
            {
                MessageBox.Show("Không có sản phẩm nào được chọn !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            if (_currentSelectedProduct.Quantity <= 0)
            {
                MessageBox.Show("Sản phẩm đã hết hàng !",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int qty))
            {
                MessageBox.Show("Số lượng hàng phải thuộc kiểu số !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

            if (qty < 0)
            {
                MessageBox.Show("Số lượng hàng hoá phải là lớn hơn 0 !"
                   , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OrderDetail orderDetail = new OrderDetail();
            orderDetail.ProductId = _currentSelectedProduct.ProductId;
            orderDetail.ProductName = _currentSelectedProduct.ProductName;
            orderDetail.Quantity = qty;
            orderDetail.Price = _currentSelectedProduct.SalePrice;
            AddToOrderList(orderDetail);
        }

        private void AddToOrderList(OrderDetail orderDetail)
        {
            OrderDetail _item = _orderDetails.FirstOrDefault(x => x.ProductId == orderDetail.ProductId);

            if (_item != null)
            {
                if ((_item.Quantity + orderDetail.Quantity) > _currentSelectedProduct.Quantity)
                {
                    MessageBox.Show(string.Format("Chỉ có thể mua tối đa {0} sản phẩm !", _currentSelectedProduct.Quantity)
                        , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _item.Quantity = _item.Quantity + orderDetail.Quantity;
            }
            else
            {
                if (orderDetail.Quantity > _currentSelectedProduct.Quantity)
                {
                    MessageBox.Show(string.Format("Chỉ có thể mua tối đa {0} sản phẩm !", _currentSelectedProduct.Quantity)
                        , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _orderDetails.Add(orderDetail);
            }

            LoadGridData();
        }

        private void CalculateSumTotal()
        {
            var sumTotal = _orderDetails.Sum(x => x.Quantity * x.Price);
            txtTotal.Text = string.Format("{0:#,###.##}", sumTotal);
        }

        private void gridOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridOrderDetail.CurrentRow == null || gridOrderDetail.CurrentRow.IsNewRow)
                return;

            if (gridOrderDetail.CurrentRow.Cells[e.ColumnIndex] is DataGridViewButtonCell)
            {
                var obj = gridOrderDetail.CurrentRow.DataBoundItem as OrderDetail;

                if (obj == null)
                    return;

                var item = _orderDetails.FirstOrDefault(x => x.ProductId == obj.ProductId);

                if (item != null)
                {
                    _orderDetails.Remove(item);
                    LoadGridData();
                }
            }
        }

        OrderDAL _orderDAL = new OrderDAL();
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (_orderDetails.Count <= 0)
            {
                MessageBox.Show("Không có sản phẩm nào trong đơn hàng !"
                    , "Thông báo", MessageBoxButtons.OK , MessageBoxIcon.Error);
                return;
            }

            Order order = new Order();
            order.CustomerId = _customer.CustomerId;
            order.OrderDate = DateTime.Now;
            order.TotalPrice = _orderDetails.Sum(x => x.Quantity * x.Price);

            int orderId = _orderDAL.CreateOrder(order, _orderDetails);
            
            if (orderId <= 0)
            {
                var f = new NotifyForm();
                f.SetAlertFor("Thông báo cho Khách Hàng");
                f.ShowAlert("Thêm mới đơn hàng không thành công !");
                return;
            }

            var f1 = new NotifyForm();
            f1.SetAlertFor("Thông báo cho Khách Hàng");
            f1.ShowAlert("Thêm mới đơn hàng thành công !");

            _orderDetails.Clear();
            LoadGridData();
            LoadProducts();
        }

        private void chkWishList_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkWistList.Checked)
            {
                LoadProducts();
                return;
            }

            LoadProductsInWishList();
        }

        private void LoadProductsInWishList()
        {
            panelProducts.Controls.Clear();

            List<Product> products = _productDAL.GetAllProductInWishList(_customer.CustomerId);

            foreach (var product in products)
            {
                ProductItem item = new ProductItem();
                item.Name = "product_" + product.ProductId.ToString();
                item.ProductSelectHandler += Item_ProductSelectHandler;
                panelProducts.Controls.Add(item);
                item.Product = product;
            }

            txtProductName.Text = "";
            txtQuantity.Text = "";
        }

        private void FormPOScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ProductQuantityChangeSubject.Unregister(productChangeObserver);
        }

        private void productItem3_Load(object sender, EventArgs e)
        {

        }

        private void productItem1_Load(object sender, EventArgs e)
        {

        }
    }
}
