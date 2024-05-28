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
    public partial class FormCustomerManager : Form
    {
        public FormCustomerManager()
        {
            InitializeComponent();
        }

        CustomerDAL _customerDAL = new CustomerDAL();
        BindingSource _src = new BindingSource();
        private void FormCustomerManager_Load(object sender, EventArgs e)
        {
            gridCustomer.AutoGenerateColumns = false;
            gridCustomer.DataSource = _src;
            LoadGrid();
        }

        private void LoadGrid()
        {
            _src.DataSource = _customerDAL.GetAll();
            _src.ResetBindings(true);
        }

        private void gridCustomer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var obj = GetCurrentCustomer();
            if (obj == null)
                return;
            Display(obj);
        }

        private void Display(Customer obj)
        {
            txtCustomername.Text = obj.CustomerName;
            
            if (obj.Gender.ToLower() == "nam" 
                || obj.Gender.ToLower() == "male")
            {
                rdoNam.Checked = true;
                rdoNu.Checked = false;
            }
            else
            {
                rdoNam.Checked = false;
                rdoNu.Checked = true;
            } 

            txtPhone.Text = obj.Phone;
            txtAddress.Text = obj.Address;
            txtPassword.Text = obj.Password;

        }

        private Customer GetCurrentCustomer()
        {
            if (gridCustomer.CurrentRow == null || gridCustomer.CurrentRow.IsNewRow)
                return null;
            var obj = gridCustomer.CurrentRow.DataBoundItem as Customer;
            return obj;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtCustomername.Text = "";
            rdoNam.Checked = true;
            txtPhone.Text = "";
            txtPassword.Text = "";
            txtAddress.Text = "";
            txtTimKiem.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obj = GetCurrentCustomer();

            if (obj == null)
            {
                MessageBox.Show("Không có khách hàng nào được chọn !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show(string.Format("Bạn muốn xoá khách hàng [{0}] ?", obj.CustomerName)
                , "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result != DialogResult.Yes)
                return;

            var ret = _customerDAL.Delete(obj.CustomerId);

            if (ret > 0)
            {
                MessageBox.Show("Xoá thông tin khách hàng thành công !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
                return;
            }

            MessageBox.Show("Xoá thông tin khách hàng không thành công !"
                   , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = GetCurrentCustomer();

            if (obj == null)
            {
                MessageBox.Show("Không có khách hàng nào được chọn !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtCustomername.Text))
            {
                MessageBox.Show("Tên khách hàng không được để trống !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

            obj.CustomerName = txtCustomername.Text;

            if (rdoNam.Checked)
                obj.Gender = "Nam";
            else
                obj.Gender = "Nữ";

            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            obj.Phone = txtPhone.Text;

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Text = "123";
            }

            obj.Password = txtPassword.Text;
            obj.Address = txtAddress.Text;

            var ret = _customerDAL.Update(obj);

            if (ret > 0)
            {
                MessageBox.Show("Cập nhật thông tin khách hàng thành công !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
                return;
            }

            MessageBox.Show("Cập nhật thông tin khách hàng không thành công !"
                   , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var obj = new Customer();

            if (string.IsNullOrEmpty(txtCustomername.Text))
            {
                MessageBox.Show("Tên khách hàng không được để trống !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            obj.CustomerName = txtCustomername.Text;

            if (rdoNam.Checked)
                obj.Gender = "Nam";
            else
                obj.Gender = "Nữ";

            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            obj.Phone = txtPhone.Text;

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Text = "123";
            }

            obj.Password = txtPassword.Text;
            obj.Address = txtAddress.Text;

            var ret = _customerDAL.Insert(obj);

            if (ret > 0)
            {
                MessageBox.Show("Thêm mới thông tin khách hàng thành công !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
                return;
            }

            MessageBox.Show("Thêm mới thông tin khách hàng không thành công !"
                   , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchTerm = txtTimKiem.Text;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                LoadGrid();
            }

            List<Customer> customers = _customerDAL.GetAll();
            customers = customers.Where(x => x.CustomerName.ToLower().Contains(searchTerm.ToLower()))
                .ToList();
            _src.DataSource = customers;
            _src.ResetBindings(true);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
