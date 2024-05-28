using MiniMarket.DAL;
using MiniMarket.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMarket.GUI
{
    public partial class FormOrderManager : Form
    {
        public FormOrderManager()
        {
            InitializeComponent();
        }

        OrderDAL _orderDAL = new OrderDAL();
        OrderDetailDAL _orderDetailDAL = new OrderDetailDAL();
        BindingSource _src = new BindingSource();
        BindingSource _srcDetail = new BindingSource();
        CustomerDAL _customerDAL = new CustomerDAL();
        private void FormOrderManager_Load(object sender, EventArgs e)
        {
            gridOrder.AutoGenerateColumns = false;
            gridOrder.DataSource = _src;
            gridOrderDetail.AutoGenerateColumns = false;
            gridOrderDetail.DataSource = _srcDetail;
            LoadComboCustomer();
            LoadGrid();
        }

        private void LoadComboCustomer()
        {
            cboCustomer.DataSource = _customerDAL.GetAll();
            cboCustomer.DisplayMember = "CustomerName";
            cboCustomer.ValueMember = "CustomerId";
            cboCustomer.SelectedIndex = 0;
        }

        private void LoadGrid()
        {
            _src.DataSource = _orderDAL.GetAll();
            _src.ResetBindings(true);
            LoadGridDetail(new List<OrderDetail>());
        }

        private void LoadGridDetail(List<OrderDetail> details)
        {
            _srcDetail.DataSource = details;
            _srcDetail.ResetBindings(true);
        }

        private void gridOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var obj = getCurrentOrder();
            if (obj == null)
                return;
            Display(obj);
        }

        private void Display(Order obj)
        {
            cboCustomer.SelectedValue = obj.CustomerId;
            dtOrderDate.Value = obj.OrderDate;
            txtTotalPrice.Text = obj.TotalPrice.ToString("#,###.##");
            List<OrderDetail> orderDetails = _orderDetailDAL.GetByOrderId(obj.OrderId);
            LoadGridDetail(orderDetails);
        }

        private Order getCurrentOrder()
        {
            if (gridOrder.CurrentRow == null 
                || gridOrder.CurrentRow.IsNewRow)
                return null;
            var obj = gridOrder.CurrentRow.DataBoundItem as Order;
            return obj;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obj = getCurrentOrder();
            
            if (obj == null)
                return;
            
            var result = MessageBox.Show("Bạn muốn xoá hoá đơn được chọn ?"
                , "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result != DialogResult.Yes)
                return;

            var ret = _orderDAL.DeleteOrder(obj.OrderId);
            
            if (ret > 0)
            {
                MessageBox.Show("Xoá hoá đơn thành công !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboCustomer.SelectedIndex = 0;
                dtOrderDate.Value = DateTime.Now;
                txtTotalPrice.Text = "0";
                LoadGrid();
                return;
            }

            MessageBox.Show("Xoá hoá đơn không thành công !"
                , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchTerm = txtTimKiem.Text;
            
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                LoadGrid();
            }

            List<Order> orders = _orderDAL.GetAll();
            orders = orders.Where(x => x.CustomerName.ToLower().Contains(searchTerm.ToLower()))
                .ToList();
            _src.DataSource = orders;
            _src.ResetBindings(true);
            LoadGridDetail(new List<OrderDetail>());
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
