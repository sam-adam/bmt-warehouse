namespace Warehouse.Presentation.View
{
    using Warehouse.Business.Contract;
    using Warehouse.Data.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    public partial class ProductSubcategoryView : Form
    {
        private readonly IProductSubcategoryBl _subcategoryBl;
        private ProductSubcategory _subcategory;
        public ProductSubcategory ProductSubcategory
        {
            get { return _subcategory; }
            internal set { _subcategory = value; }
        }

        public ProductSubcategoryView(IProductSubcategoryBl subcategoryBl)
        {
            _subcategoryBl = subcategoryBl;

            InitializeComponent();
        }

        private void ProductSubcategoryView_Load(object sender, EventArgs e)
        {
            cboCriteria.SelectedIndex = 0;

            _subcategory = null;

            txtKeyword.Clear();
            txtKeyword.Focus();

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
            IList<ProductSubcategory> productSubcategories = null;

            dgvProductSubcategory.Rows.Clear();

            if (string.IsNullOrEmpty(txtKeyword.Text))
            {
                productSubcategories = _subcategoryBl.GetAll();
            }
            else
            {
                switch (cboCriteria.SelectedItem.ToString())
                {
                    case "Subcategory Id":
                        productSubcategories = _subcategoryBl.Get(sub => sub.Id.Contains(txtKeyword.Text));
                        break;

                    case "Subcategory":
                        productSubcategories = _subcategoryBl.Get(sub => sub.Subcategory.Contains(txtKeyword.Text));
                        break;

                    case "Category Id":
                        productSubcategories = _subcategoryBl.Get(sub => sub.Category.Id.Contains(txtKeyword.Text));
                        break;

                    case "Category":
                        productSubcategories = _subcategoryBl.Get(sub => sub.Category.Category.Contains(txtKeyword.Text));
                        break;
                }
            }

            if (productSubcategories != null)
            {
                foreach (var productSubcategory in productSubcategories)
                {
                    dgvProductSubcategory.Rows.Add(productSubcategory.Id, productSubcategory.Subcategory, productSubcategory.Category.Id, productSubcategory.Category.Category);
                }
            }

            if (dgvProductSubcategory.CurrentRow != null) SetSelectedSubcategory(dgvProductSubcategory.CurrentRow.Cells["SubcategoryId"].Value.ToString());
        }

        private void dgvProductSubcategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductSubcategory = _subcategory;

            Close();
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void dgvProductSubcategory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductSubcategory.CurrentRow != null)
            {
                SetSelectedSubcategory(dgvProductSubcategory.CurrentRow.Cells["SubcategoryId"].Value.ToString());   
            }
        }

        private void SetSelectedSubcategory(string subcategoryId)
        {
            _subcategory = _subcategoryBl.Get(subcategoryId).FirstOrDefault();
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