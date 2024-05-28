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
    public partial class FormImportManager : Form
    {
        public FormImportManager()
        {
            InitializeComponent();
        }

        ProductDAL _productDAL = new ProductDAL();
        ImportDAL _importDAL = new ImportDAL();
        ImportDetailDAL _importDetailDAL = new ImportDetailDAL();

        BindingSource _importSrc = new BindingSource();
        BindingSource _importDetailSrc = new BindingSource();

        private void FormImportManager_Load(object sender, EventArgs e)
        {
            LoadProductCombo();
            gridImport.AutoGenerateColumns = false;
            gridImport.DataSource = _importSrc;
            gridImportDetail.AutoGenerateColumns = false;
            gridImportDetail.DataSource = _importDetailSrc;
            LoadGrid();
            
        }

        private void LoadProductCombo()
        {
            cboProduct.DataSource = _productDAL.GetAll();
            cboProduct.ValueMember = "ProductId";
            cboProduct.DisplayMember = "ProductName";
            cboProduct.SelectedIndex = 0;
        }

        private void LoadGrid()
        {
            _importSrc.DataSource = _importDAL.GetAll();
            _importSrc.ResetBindings(true);
            cboProduct.SelectedIndex = 0;
            LoadGridDetail(new List<ImportDetail>());
        }

        private void LoadGridDetail(List<ImportDetail> details)
        {
            _importDetailSrc.DataSource = details;
            _importDetailSrc.ResetBindings(true);
        }

        private void gridImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var obj = getCurrentImport();
            if (obj == null)
                return;
            Display(obj);
        }

        private void Display(Import obj)
        {
            dtImportDate.Value = obj.ImportDate;
            List<ImportDetail> importDetails = _importDetailDAL.GetByImportId(obj.ImportId);
            LoadGridDetail(importDetails);
            cboProduct.SelectedIndex = 0;
            txtQuantity.Text = "";
            btnThemCT.Enabled = false;
            btnXoaCT.Enabled = false;
        }

        private Import getCurrentImport()
        {
            if (gridImport.CurrentRow == null || gridImport.CurrentRow.IsNewRow)
                return null;

            var obj = gridImport.CurrentRow.DataBoundItem as Import;
            return obj;
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            if (cboProduct.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Vui lòng nhập số lượng sản phẩm !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<ImportDetail> importDetails = _importDetailSrc.DataSource as List<ImportDetail>;
            
            if (importDetails == null)
            {
                importDetails = new List<ImportDetail>();
                LoadGridDetail(importDetails);
            }

            var detail = importDetails
                .Where(x => x.ProductId == (cboProduct.SelectedItem as Product).ProductId)
                .FirstOrDefault();

            if (detail != null)
            {
                detail.Quantity += quantity;
            }
            else
            {
                detail = new ImportDetail();
                detail.ProductId = (cboProduct.SelectedItem as Product).ProductId;
                detail.ProductName = (cboProduct.SelectedItem as Product).ProductName;
                detail.Quantity = quantity;
                importDetails.Add(detail);
            }

            _importDetailSrc.ResetBindings(false);
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            if (gridImportDetail.CurrentRow == null || gridImportDetail.CurrentRow.IsNewRow)
                return;
            
            var obj = gridImportDetail.CurrentRow.DataBoundItem as ImportDetail;
            
            if (obj == null)
                return;

            var answer = MessageBox.Show("Bạn muốn xoá hàng hoá này khỏi danh sách nhập ?"
                , "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
                return;

            var importDetails = _importDetailSrc.DataSource as List<ImportDetail>;

            if (importDetails != null)
            {
                importDetails.Remove(obj);
            }

            _importDetailSrc.ResetBindings(false);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dtImportDate.Value = DateTime.Now;
            LoadGridDetail(new List<ImportDetail>());
            cboProduct.SelectedIndex = 0;
            txtQuantity.Text = "1";
            btnThemCT.Enabled = true;
            btnXoaCT.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridImport.CurrentRow == null || gridImport.CurrentRow.IsNewRow)
                return;

            var obj = gridImport.CurrentRow.DataBoundItem as Import;

            if (obj == null)
                return;

            var answer = MessageBox.Show("Bạn muốn xoá phiếu nhập này khỏi danh sách nhập ?"
                , "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
                return;

            var ret = _importDAL.Delete(obj.ImportId); 

            if (ret > 0)
            {
                MessageBox.Show("Xoá phiếu nhập thành công !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadGrid();
                return;
            } 
            
            MessageBox.Show("Xoá phiếu nhập không thành công !"
                , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnThemCT.Enabled == false)
                return;

            List<ImportDetail> importDetails = _importDetailSrc.DataSource as List<ImportDetail>;

            if (importDetails == null)
            {
                importDetails = new List<ImportDetail>();
            }

            if (importDetails.Count <= 0)
            {
                MessageBox.Show("Không có sản phẩm nào trong danh sách nhập !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 


            Import import = new Import();
            import.Username = FormManager.LoginAccount.Username;
            import.ImportDate = dtImportDate.Value;

            var ret = _importDAL.Insert(import);

            if (ret > 0)
            {
                foreach (var importDetail in importDetails)
                {
                    importDetail.ImportId = ret;
                    if (_importDetailDAL.Insert(importDetail) > 0)
                    {
                        int inStock = _productDAL.UpdateImport(importDetail.ProductId, importDetail.Quantity);
                        
                        if (inStock > 0)
                        {
                            Program.ProductQuantityChangeSubject
                               .SetNotifyMessage(string.Format("Sản phẩm {0}-{1} vừa được nhập hàng !"
                               , importDetail.ProductId, importDetail.ProductName)
                               , PATTERN.SubjectForType.Customer);
                        } 
                    }    
                }

                MessageBox.Show("Thêm mới đơn nhập thành công !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadGrid();
                return;
            }

            MessageBox.Show("Thêm mới đơn nhập không thành công !"
                , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void chkDisplayOutSTock_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDisplayOutSTock.Checked == true)
            {
                var outStockProducts = _productDAL.GetOutStockProduct();
                cboProduct.DataSource = outStockProducts;
                cboProduct.ValueMember = "ProductId";
                cboProduct.DisplayMember = "ProductName";
                if (outStockProducts.Count > 0)
                    cboProduct.SelectedIndex = 0;
            }
            else
            {
                LoadProductCombo();
            } 
        }

        private void gridImportDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
