using System.Windows.Forms;

namespace Warehouse.Presentation.View
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using Warehouse.Business;
    using Warehouse.Data.Model;

    public partial class RentalProductAdjustmentView : Warehouse.Presentation.Common.BaseForm
    {
        private readonly RentalProductAdjustmentBl _bl;

        public RentalProductAdjustmentView(RentalProductAdjustmentBl bl)
        {
            _bl = bl;

            InitializeComponent();
        }

        private void RentalProductAdjustmentView_Load(object sender, EventArgs e)
        {
            txtKeyword.Clear();
            cboCriteria.SelectedIndex = 0;

            RefreshList();
        }

        private void RefreshList()
        {
            try
            {
                dgvRentalProductAdjustment.Rows.Clear();

                IList<RentalProductAdjustment> adjustments = null;

                if (txtKeyword.Text == string.Empty)
                {
                    adjustments = _bl.GetAll();
                }
                else
                {
                    switch (cboCriteria.SelectedItem.ToString())
                    {
                        case "Customer":
                            adjustments = _bl.Get(adj => adj.Customer.Name.Contains(txtKeyword.Text));
                            break;
                        case "Adjustment Date":
                            adjustments = _bl.Get(adj => adj.CreatedDate.ToString(CultureInfo.InvariantCulture).Contains(txtKeyword.Text));
                            break;
                        case "Product Id":
                            adjustments = _bl.Get(adj => adj.Details.Any(dtl => dtl.RentalProduct.Id.Contains(txtKeyword.Text)));
                            break;
                        case "Admin":
                            adjustments = _bl.Get(adj => adj.CreatedBy.Name.Contains(txtKeyword.Text));
                            break;
                    }
                }

                if (adjustments != null)
                {
                    foreach (var adjustment in adjustments)
                    {
                        dgvRentalProductAdjustment.Rows.Add(
                            adjustment.Id,
                            adjustment.Customer.Id,
                            adjustment.Customer.Name,
                            adjustment.CreatedDate.ToShortDateString(),
                            adjustment.CreatedBy.Id,
                            adjustment.CreatedBy.Name
                            );
                    }
                }

                SetDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void SetDetails()
        {
            dgvRentalProductAdjustmentDetail.Rows.Clear();

            if (dgvRentalProductAdjustment.CurrentRow != null)
            {
                var adjustment = _bl.GetById(dgvRentalProductAdjustment.CurrentRow.Cells["Id"].Value.ToString());

                if (adjustment != null)
                {
                    foreach (var detail in adjustment.Details)
                    {
                        dgvRentalProductAdjustmentDetail.Rows.Add(
                            detail.RentalProduct.Id,
                            detail.RentalProduct.ProductCategory.Id,
                            detail.RentalProduct.ProductCategory.Category,
                            detail.RentalProduct.ProductSubcategory.Id,
                            detail.RentalProduct.ProductSubcategory.Subcategory,
                            detail.RentalProduct.Brand,
                            detail.RentalProduct.Description,
                            detail.PreviousStock,
                            detail.AdjustedStock
                            );
                    }
                }
            }
        }

        private void dgvRentalProductAdjustment_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRentalProductAdjustment.CurrentRow != null)
            {
                SetDetails();
            }
        }
    }
}
