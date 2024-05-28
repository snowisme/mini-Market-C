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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        AccountDAL _accountDAL = new AccountDAL();
        
        CustomerDAL _customerDAL = new CustomerDAL();

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cboLoginType.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản đăng nhập !"
                    , "Thông báo"
                    , MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cboLoginType.Focus();
                return;
            } 

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                if (cboLoginType.SelectedIndex == 0)
                    MessageBox.Show("Vui lòng nhập vào Tên đăng nhập !"
                        , "Thông báo - Đăng nhập quản trị"
                        , MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                if (cboLoginType.SelectedIndex == 1)
                    MessageBox.Show("Vui lòng nhập vào Số điện thoại !"
                        , "Thông báo - Đăng nhập khách hàng"
                        , MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập vào mật khẩu đăng nhập !"
                   , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtPassword.Focus();
                return;
            } 

            if (cboLoginType.SelectedIndex == 0)
            {
                DoManagerLogin();
            } 

            if (cboLoginType.SelectedIndex == 1)
            {
                DoCustomerLogin();
            }
        }

        private void DoCustomerLogin()
        {
            Customer customer = _customerDAL.Login(txtUsername.Text, txtPassword.Text);

            if (customer == null)
            {
                MessageBox.Show("Đăng nhập khách hàng không thành công ! Vui lòng kiểm tra lại thông tin đăng nhập !"
                 , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            MessageBox.Show("Đăng nhập khách hàng thành công !"
                 , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //this.Hide();
            FormPOScreen frm = new FormPOScreen(customer);
            frm.Show();
            //this.Show();

        }
        private void DoManagerLogin()
        {
            Account account = _accountDAL.Login(txtUsername.Text, txtPassword.Text);

            if (account == null)
            {
                MessageBox.Show("Đăng nhập quản trị không thành công ! Vui lòng kiểm tra lại thông tin đăng nhập !"
                 , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            MessageBox.Show("Đăng nhập quản trị thành công !"
                 , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Hide();
            FormManager frm = new FormManager();
            FormManager.LoginAccount = account;
            frm.Show();
            //this.Show();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            cboLoginType.SelectedIndex = 0;
        }

        private void cboLoginType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoginType.SelectedIndex == 0)
            {
                txtUsername.Text = "admin";
                txtPassword.Text = "admin";
            }

            if (cboLoginType.SelectedIndex == 1)
            {
                txtUsername.Text = "111111";
                txtPassword.Text = "123";
            }
        }
    }
}
