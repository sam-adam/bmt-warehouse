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
        public Form Caller { get; set; }
        private Customer _customer;
        public Customer Customer { get; private set; }

        public CustomerView(ICustomerBl customerBl)
        {
            _customerBl = customerBl;

            InitializeComponent();
        }

        private void Customer_Load(object sender, System.EventArgs e)
        {
            cboCriteria.SelectedIndex = 0;

            _customer = null;

            txtKeyword.Clear();
            txtKeyword.Focus();

            RefreshList();
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                SetCustomerPreview(dgvCustomers.CurrentRow.Cells["Id"].Value.ToString());
            }
        }

        private void RefreshList()
        {
            IList<Customer> customers = null;

            dgvCustomers.Rows.Clear();
            
            if (string.IsNullOrEmpty(txtKeyword.Text))
            {
                customers = _customerBl.GetAll();
            }
            else
            {
                switch (cboCriteria.SelectedItem.ToString())
                {
                    case "Name":
                        customers = _customerBl.Get(cust => cust.Name.Contains(txtKeyword.Text));
                        break;

                    case "Title":
                        customers = _customerBl.Get(cust => cust.Title.Contains(txtKeyword.Text));
                        break;

                    case "Phone":
                        customers = _customerBl.Get(cust => cust.Phone.Contains(txtKeyword.Text));
                        break;

                    case "Email":
                        customers = _customerBl.Get(cust => cust.Email.Contains(txtKeyword.Text));
                        break;

                    case "NPWP":
                        customers = _customerBl.Get(cust => cust.TaxId.Contains(txtKeyword.Text));
                        break;
                }
            }

            if (customers != null)
            {
                foreach (var customer in customers)
                {
                    dgvCustomers.Rows.Add(customer.Id, customer.Name, customer.Title, customer.Phone, customer.Email, customer.TaxId);
                }
            }

            if (dgvCustomers.CurrentRow != null) SetCustomerPreview(dgvCustomers.CurrentRow.Cells["Id"].Value.ToString());
        }

        private void SetCustomerPreview(string customerId)
        {
            _customer = _customerBl.Get(cust => cust.Id == customerId).FirstOrDefault();

            if (_customer != null)
            {
                lblCustomer.Text = string.Format("{0} : {1}", _customer.Id, _customer.Name);
                lblTitleValue.Text = string.Format("{0}", _customer.Title);
                lblEmailValue.Text = string.Format("{0}", _customer.Email);
                lblPhoneValue.Text = string.Format("{0}", _customer.Phone);
                lblCreditLimitValue.Text = string.Format("{0}", _customer.CreditLimit);
                lblJoinDateValue.Text = DateTime.Parse(_customer.JoinDate).ToLongDateString();
                lblAddress1Value.Text = string.Format("{0}", _customer.Address1);
                lblAddress2Value.Text = string.Format("{0}", _customer.Address2);
                lblAddress3Value.Text = string.Format("{0}", _customer.Address3);
                lblContactPersonValue.Text = string.Format("{0}", _customer.ContactPerson);
                lblActiveRentalValue.Text = _customer.HasRentalAgreement() ? string.Format("{0}", _customer.GetActiveRental().Id) : @"-";
            }
            else
            {
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
            Customer = _customer;

            Close();
        }

        private void dgvCustomers_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }

        private void dgvCustomers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && !dgvCustomers.IsCurrentCellInEditMode)
            {
                e.Handled = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Customer = _customer;

            if (keyData == Keys.Enter && Caller != null)
            {
                if (Customer == null)
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
    }
}
