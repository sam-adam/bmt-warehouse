namespace Warehouse.Presentation.View
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Warehouse.Business.Contract;
    using Warehouse.Data.Model;

    public partial class ProductSubcategoryView : Form
    {
        private readonly IProductSubcategoryBl _productSubcategoryBl;

        private IList<ProductSubcategory> _productSubcategories;

        public ProductSubcategory ProductSubcategory { get; private set; }

        public ProductSubcategoryView(IProductSubcategoryBl productSubcategoryBl)
        {
            _productSubcategoryBl = productSubcategoryBl;

            InitializeComponent();
        }

        private void ProductSubcategoryView_Load(object sender, EventArgs e)
        {
            txtKeyword.Text = string.Empty;
            cboCriteria.SelectedIndex = 0;

            RefreshList();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (ProductSubcategory == null)
                {
                    MessageBox.Show(@"No selected subcategory");
                }
                else
                {
                    Close();
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void RefreshList()
        {
            dgvProductSubcategory.Rows.Clear();

            if (string.IsNullOrEmpty(txtKeyword.Text))
            {
                _productSubcategories = _productSubcategoryBl.GetAll();
            }
            else
            {
                switch (cboCriteria.SelectedItem.ToString())
                {
                    case "Subcategory Id":
                        _productSubcategories = _productSubcategoryBl.Get(sub => sub.Id.Contains(txtKeyword.Text));
                        break;

                    case "Subcategory":
                        _productSubcategories = _productSubcategoryBl.Get(sub => sub.Subcategory.Contains(txtKeyword.Text));
                        break;

                    case "Category Id":
                        _productSubcategories = _productSubcategoryBl.Get(sub => sub.Category.Id.Contains(txtKeyword.Text));
                        break;

                    case "Category":
                        _productSubcategories = _productSubcategoryBl.Get(sub => sub.Category.Category.Contains(txtKeyword.Text));
                        break;
                }
            }

            SetSelectedSubcategory();
        }

        private void dgvProductSubcategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void dgvProductSubcategory_SelectionChanged(object sender, EventArgs e)
        {
            SetSelectedSubcategory();
        }

        private void SetSelectedSubcategory()
        {
            if (_productSubcategories != null)
            {
                foreach (var productSubcategory in _productSubcategories)
                {
                    dgvProductSubcategory.Rows.Add(productSubcategory.Id, productSubcategory.Subcategory, productSubcategory.Category.Id, productSubcategory.Category.Category);
                }

                if (dgvProductSubcategory.CurrentRow != null)
                {
                    ProductSubcategory = _productSubcategoryBl.Get(dgvProductSubcategory.CurrentRow.Cells["SubcategoryId"].Value.ToString()).First();
                }
            }
            else
            {
                ProductSubcategory = null;
            }
        }

        private void dgvProductSubcategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !dgvProductSubcategory.IsCurrentCellInEditMode)
            {
                e.Handled = true;
            }
        }
    }
}
