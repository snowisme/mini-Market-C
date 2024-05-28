using MiniMarket.DAL;
using MiniMarket.DTO;
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
    public partial class FormAccountManager : Form
    {
        public FormAccountManager()
        {
            InitializeComponent();
        }
        
        AccountDAL _accountDAL = new AccountDAL();
        BindingSource _src = new BindingSource();

        private void FormAccountManager_Load(object sender, EventArgs e)
        {
            gridAccount.AutoGenerateColumns = false;
            gridAccount.DataSource = _src;
            LoadGrid();
        }

        private void LoadGrid()
        {
            _src.DataSource = _accountDAL.GetAll();
            _src.ResetBindings(true);
        }

        private void gridAccount_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var obj = getCurrentAccount();
            if (obj == null)
                return;
            Display(obj);
        }

        private void Display(Account obj)
        {
            txtUsername.Text = obj.Username;
            txtPassword.Text = obj.Password;
        }

        private Account getCurrentAccount()
        {
            if (gridAccount.CurrentRow == null || gridAccount.CurrentRow.IsNewRow)
                return null;
            var obj = gridAccount.CurrentRow.DataBoundItem as Account;
            return obj;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obj = getCurrentAccount();
            
            if (obj == null)
            {
                MessageBox.Show("Không có tài khoản nào được chọn !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (FormManager.LoginAccount == null)
                return;

            if (FormManager.LoginAccount.Username == obj.Username)
            {
                MessageBox.Show("Bạn không thể xoá tài khoản đang đăng nhập !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ret = _accountDAL.Delete(obj.Username);

            if (ret > 0)
            {
                MessageBox.Show("Xoá tài khoản thành công !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
                return;
            }

            MessageBox.Show("Xoá thông tin tài khoản không thành công !"
                , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);            

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = getCurrentAccount();

            if (obj == null)
            {
                MessageBox.Show("Không có tài khoản nào được chọn !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (FormManager.LoginAccount == null)
                return;

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

            obj.Password = txtPassword.Text;

            var ret = _accountDAL.Update(obj);

            if (ret > 0)
            {
                MessageBox.Show("Thay đổi mật khẩu tài khoản thành công !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
                return;
            }

            MessageBox.Show("Thay đổi mật khẩu tài khoản không thành công !"
                , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Tên đăng nhập không được để trống !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_accountDAL.Exists(txtUsername.Text))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var obj = new Account();
            obj.Username = txtUsername.Text;
            obj.Password = txtPassword.Text;

            var ret = _accountDAL.Insert(obj);

            if (ret > 0)
            {
                MessageBox.Show("Thêm mới tài khoản thành công !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
                return;
            }

            MessageBox.Show("Thêm mới tài khoản không thành công !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchTerm = txtUsername.Text;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                LoadGrid();
            }

            List<Account> accounts = _accountDAL.GetAll();
            accounts = accounts.Where(x => x.Username.ToLower().Contains(searchTerm.ToLower()))
                .ToList();
            _src.DataSource = accounts;
            _src.ResetBindings(true);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
