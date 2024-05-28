using MiniMarket.DAL;
using MiniMarket.DTO;
using MiniMarket.GUI;
using MiniMarket.PATTERN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMarket
{
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
        }

        public static Account LoginAccount { get; set; }

        private ProductDAL _productDAL = new ProductDAL();

        // Khởi tạo User Observer để Notify cảnh báo
        ProductOutOfStockNotifyForAdminObserver observer = new ProductOutOfStockNotifyForAdminObserver(Program.ProductQuantityChangeSubject);

        private void FormManager_Load(object sender, EventArgs e)
        {

            var outStockProduct = _productDAL.GetOutStockProduct();

            btnOutStockAlert.Visible = false;

            // Có sản phẩm đã hết hàng
            if (outStockProduct.Count > 0)
            {
                // Hiển thị cảnh báo bằng hộp thoại
                Program.ProductQuantityChangeSubject
                    .SetNotifyMessage("Có sản phẩm trong hệ thống đã hết hàng !"
                    , SubjectForType.Admin);
                btnOutStockAlert.Visible = true;
                FormOutStockAlert frm = new FormOutStockAlert(this);
                ShowForm(frm);
            } 
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            FormCustomerManager frm = new FormCustomerManager();
            ShowForm(frm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Program.ProductQuantityChangeSubject.Unregister(observer);
            this.Close();
        }

        private void ShowForm(Form frm)
        {
            pnlMainContent.Controls.Clear();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(frm);
            frm.Show();
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            FormOrderManager frm = new FormOrderManager();
            ShowForm(frm);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            FormProductManager frm = new FormProductManager();
            ShowForm(frm);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            FormAccountManager frm = new FormAccountManager();
            ShowForm(frm);
        }

        public void btnImportProduct_Click(object sender, EventArgs e)
        {
            FormImportManager frm = new FormImportManager();
            ShowForm(frm);
        }

        private void btnOutStockAlert_Click(object sender, EventArgs e)
        {
            FormOutStockAlert frm = new FormOutStockAlert(this);
            ShowForm(frm);
        }
    }
}
