using System;
using System.Windows.Forms;
using BankUI.BL;
using BankUI.DL;
namespace BankUI
{
    public partial class CustomerApplyAdminForm : Form
    {
        public string LoggedInUser { get; set; }
        public CustomerApplyAdminForm(string user)
        {
            InitializeComponent();
            LoggedInUser = user;
        }
        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            CustomerDashBoardForm f = new CustomerDashBoardForm(LoggedInUser);
            f.Show();
            this.Hide();
        }

        private void btnNavTransfer_Click(object sender, EventArgs e)
        {
            CustomerTransferForm f = new CustomerTransferForm(LoggedInUser);
            f.Show();
            this.Hide();
        }

        private void btnNavDebitCard_Click(object sender, EventArgs e)
        {
            CustomerApplyDebitCardForm f = new CustomerApplyDebitCardForm(LoggedInUser);
            f.Show();
            this.Hide();
        }

        private void btnNavLoan_Click(object sender, EventArgs e)
        {
            CustomerLoanRequestForm f = new CustomerLoanRequestForm(LoggedInUser);
            f.Show();
            this.Hide();
        }

        private void btnNavAdminReq_Click(object sender, EventArgs e) { }

        private void btnNavBalance_Click(object sender, EventArgs e)
        {
            CustomerCheckBalanceForm f = new CustomerCheckBalanceForm(LoggedInUser);
            f.Show();
            this.Hide();
        }

        private void btnNavBankStmt_Click(object sender, EventArgs e)
        {
            CustomerBankStatementForm f = new CustomerBankStatementForm(LoggedInUser);
            f.Show();
            this.Hide();
        }

        private void btnNavLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            
            if (AdminRequestDl.HasAnyRequest(LoggedInUser))
            {
                MessageBox.Show("You have already submitted an admin request. Please wait for the administrator's review. Request Denied");
                return; 
            }
            AdminRequest req = new AdminRequest(0, LoggedInUser, "Pending");
            AdminRequestDl.AddRequest(req);
            lblStatus.Text = "Request Submitted";
            MessageBox.Show("Admin Request Submitted Successfully");
        }
    }
}
