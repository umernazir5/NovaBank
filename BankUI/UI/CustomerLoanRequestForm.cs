using System;
using System.Windows.Forms;
using BankUI.BL;
using BankUI.DL;
namespace BankUI
{
    public partial class CustomerLoanRequestForm : Form
    {
        public string LoggedInUser { get; set; }
        public CustomerLoanRequestForm(string user)
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

        private void btnNavLoan_Click(object sender, EventArgs e) { }

        private void btnNavAdminReq_Click(object sender, EventArgs e)
        {
            CustomerApplyAdminForm f = new CustomerApplyAdminForm(LoggedInUser);
            f.Show();
            this.Hide();
        }

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
            double amount = double.Parse(txtAmount.Text);
            Loan loan = new Loan(0, UserDl.GetUser(LoggedInUser), amount, "Pending");
            LoanDl.AddLoan(loan);
            lblStatus.Text = "Loan Requested";
            MessageBox.Show("Loan Request Submitted Successfully");
        }
    }
}
