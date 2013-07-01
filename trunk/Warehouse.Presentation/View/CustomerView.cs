namespace Warehouse.Presentation.View
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;    
    using Warehouse.Business.Contract;
    using Warehouse.Data.Model;
    using Warehouse.Presentation.Delegates;

    public partial class CustomerView : Form
    {
        public delegate void CustomerSelectedHandler(object sender, CustomerSelectedEventArgs e);
        public event CustomerSelectedHandler CustomerSelected;

        private readonly ICustomerBl _customerBl;

        public CustomerView(ICustomerBl customerBl)
        {
            _customerBl = customerBl;

            InitializeComponent();
        }

        public Customer Customer { get; set; }

        private void Customer_Load(object sender, System.EventArgs e)
        {
            cboCriteria.SelectedIndex = 0;

            Customer = null;

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
            Customer = _customerBl.Get(cust => cust.Id == customerId).FirstOrDefault();

            if (Customer != null)
            {
                lblCustomer.Text = string.Format("{0} : {1}", Customer.Id, Customer.Name);
                lblTitleValue.Text = string.Format("{0}", Customer.Title);
                lblEmailValue.Text = string.Format("{0}", Customer.Email);
                lblPhoneValue.Text = string.Format("{0}", Customer.Phone);
                lblCreditLimitValue.Text = string.Format("{0}", Customer.CreditLimit);
                lblJoinDateValue.Text = DateTime.Parse(Customer.JoinDate).ToLongDateString();
                lblAddress1Value.Text = string.Format("{0}", Customer.Address1);
                lblAddress2Value.Text = string.Format("{0}", Customer.Address2);
                lblAddress3Value.Text = string.Format("{0}", Customer.Address3);
                lblContactPersonValue.Text = string.Format("{0}", Customer.ContactPerson);
                lblActiveRentalValue.Text = Customer.HasRentalAgreement() ? string.Format("{0}", Customer.GetActiveRental().Id) : @"-";
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
            SetCustomer();
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
            Customer = Customer;

            if (keyData == Keys.Enter)
            {
                if (Customer == null)
                {
                    MessageBox.Show(@"No selected customer");
                }
                else
                {
                    SetCustomer();
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SetCustomer()
        {
            var args = new CustomerSelectedEventArgs(Customer);

            CustomerSelected(this, args);

            Close();
        }
    }
}