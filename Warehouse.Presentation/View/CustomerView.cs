namespace Warehouse.Presentation.View
{
    using Warehouse.Business;
    using Warehouse.Data.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    public partial class CustomerView : Form
    {
        private readonly CustomerBl _customerBl;
        
        private List<Customer> _customers;

        public Customer SelectedCustomer { get; set; }

        public CustomerView(CustomerBl customerBl)
        {
            _customerBl = customerBl;

            InitializeComponent();
        }

        private void Customer_Load(object sender, System.EventArgs e)
        {
            cboCriteria.SelectedIndex = 0;

            RefreshCustomerList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshCustomerList();
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            SetCustomerPreview();
        }

        private void RefreshCustomerList()
        {
            dgvCustomers.Rows.Clear();
            
            if (txtKeyword.Text == string.Empty)
            {
                _customers = _customerBl.GetCustomers();
            }
            else
            {
                switch (cboCriteria.SelectedItem.ToString())
                {
                    case "Name":
                        _customers = _customerBl.GetCustomers(cust => cust.Name.Contains(txtKeyword.Text));
                        break;

                    case "Title":
                        _customers = _customerBl.GetCustomers(cust => cust.Title.Contains(txtKeyword.Text));
                        break;

                    case "Phone":
                        _customers = _customerBl.GetCustomers(cust => cust.Phone.Contains(txtKeyword.Text));
                        break;

                    case "Email":
                        _customers = _customerBl.GetCustomers(cust => cust.Email.Contains(txtKeyword.Text));
                        break;

                    case "NPWP":
                        _customers = _customerBl.GetCustomers(cust => cust.TaxId.Contains(txtKeyword.Text));
                        break;
                }
            }

            if (_customers != null)
            {
                foreach (Customer customer in _customers)
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
            }

            if (SelectedCustomer != null && dgvCustomers.CurrentRow != null)
            {
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
            Close();
        }
    }
}
