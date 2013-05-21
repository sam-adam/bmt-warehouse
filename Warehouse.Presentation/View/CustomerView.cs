namespace Warehouse.Presentation.View
{
    using Warehouse.Business.Contract;
    using Warehouse.Data.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    public partial class CustomerView : Form
    {
        private readonly ICustomerBl _customerBl;
        
        private IList<Customer> _customers;

        public Customer SelectedCustomer { get; private set; }

        public CustomerView(ICustomerBl customerBl)
        {
            _customerBl = customerBl;

            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (SelectedCustomer == null)
                {
                    MessageBox.Show(@"No selected customer");
                }
                else
                {
                    Close();
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Customer_Load(object sender, System.EventArgs e)
        {
            cboCriteria.SelectedIndex = 0;

            txtKeyword.Text = string.Empty;
            txtKeyword.Focus();

            RefreshList();
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            SetCustomerPreview();
        }

        private void RefreshList()
        {
            dgvCustomers.Rows.Clear();
            
            if (txtKeyword.Text == string.Empty)
            {
                _customers = _customerBl.GetAll();
            }
            else
            {
                switch (cboCriteria.SelectedItem.ToString())
                {
                    case "Name":
                        _customers = _customerBl.Get(cust => cust.Name.Contains(txtKeyword.Text));
                        break;

                    case "Title":
                        _customers = _customerBl.Get(cust => cust.Title.Contains(txtKeyword.Text));
                        break;

                    case "Phone":
                        _customers = _customerBl.Get(cust => cust.Phone.Contains(txtKeyword.Text));
                        break;

                    case "Email":
                        _customers = _customerBl.Get(cust => cust.Email.Contains(txtKeyword.Text));
                        break;

                    case "NPWP":
                        _customers = _customerBl.Get(cust => cust.TaxId.Contains(txtKeyword.Text));
                        break;
                }
            }

            if (_customers != null)
            {
                foreach (var customer in _customers)
                {
                    dgvCustomers.Rows.Add(customer.Id, customer.Name, customer.Title, customer.Phone, customer.Email, customer.TaxId);
                }
            }
            
            SetCustomerPreview();
        }

        private void SetCustomerPreview()
        {
            if (dgvCustomers.CurrentRow != null)
            {
                SelectedCustomer = _customers.First(cust => cust.Id == dgvCustomers.CurrentRow.Cells["Id"].Value.ToString());

                lblCustomer.Text = string.Format("{0} : {1}", SelectedCustomer.Id, SelectedCustomer.Name);
                lblTitleValue.Text = string.Format("{0}", SelectedCustomer.Title);
                lblEmailValue.Text = string.Format("{0}", SelectedCustomer.Email);
                lblPhoneValue.Text = string.Format("{0}", SelectedCustomer.Phone);
                lblCreditLimitValue.Text = string.Format("{0}", SelectedCustomer.CreditLimit);
                lblJoinDateValue.Text = DateTime.Parse(SelectedCustomer.JoinDate).ToLongDateString();
                lblAddress1Value.Text = string.Format("{0}", SelectedCustomer.Address1);
                lblAddress2Value.Text = string.Format("{0}", SelectedCustomer.Address2);
                lblAddress3Value.Text = string.Format("{0}", SelectedCustomer.Address3);
                lblContactPersonValue.Text = string.Format("{0}", SelectedCustomer.ContactPerson);
                lblActiveRentalValue.Text = SelectedCustomer.HasRentalAgreement() ? string.Format("{0}", SelectedCustomer.GetActiveRental().Id) : @"-";
            }
            else
            {
                SelectedCustomer = null;

                lblCustomer.Text = @"-";
                lblTitleValue.Text = @"-";
                lblEmailValue.Text = @"-";
                lblPhoneValue.Text = @"-";
                lblCreditLimitValue.Text = @"-";
                lblJoinDateValue.Text = @"-";
                lblAddress1Value.Text = @"-";
                lblAddress2Value.Text = @"-";
                lblAddress3Value.Text = @"-";
                lblContactPersonValue.Text = @"-";
            }
        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }

        private void dgvCustomers_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }
    }
}
