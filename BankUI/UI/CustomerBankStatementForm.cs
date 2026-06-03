using System;
using System.Windows.Forms;
using BankUI.BL;
using BankUI.DL;
namespace BankUI
{
    public partial class CustomerBankStatementForm : Form
    {
        public string LoggedInUser { get; set; }
        public CustomerBankStatementForm(string user)
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

        private void btnNavBankStmt_Click(object sender, EventArgs e) { }

        private void btnNavLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            dgvStatement.DataSource = TransactionDl.GetTransactionsByDateRangeDataTable(LoggedInUser, dtpFrom.Value, dtpTo.Value);
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
