using MiniMarket.DAL;
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
    public partial class FormOutStockAlert : Form
    {
        public FormOutStockAlert()
        {
            InitializeComponent();
        }

        public FormOutStockAlert(FormManager formManager)
            : this()
        {
            _formManager = formManager;
        }

        ProductDAL _productDAL = new ProductDAL();
        BindingSource _src = new BindingSource();
        private FormManager _formManager;

        private void FormOutStockAlert_Load(object sender, EventArgs e)
        {
            gridProduct.DataSource = _src;
            LoadGrid();
        }

        private void LoadGrid()
        {
            _src.DataSource = _productDAL.GetOutStockProduct();
            _src.ResetBindings(true);
        }

        private void btnOpenImport_Click(object sender, EventArgs e)
        {
            _formManager.btnImportProduct_Click(sender, e);
        }
    }
}
