using System;
using System.Windows.Forms;
using BankUI.BL;
using BankUI.DL;
namespace BankUI
{
    public partial class AdminTransactionsForm : Form
    {
        public string LoggedInUser { get; set; }
        public AdminTransactionsForm(string user)
        {
            InitializeComponent();
            LoggedInUser = user;
            dgvTransactions.DataSource = TransactionDl.GetAllTransactionsDataTable();
        }
        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            AdminDashBoardForm f = new AdminDashBoardForm(LoggedInUser);
            f.Show();
            this.Hide();
        }

        private void btnNavUsers_Click(object sender, EventArgs e)
        {
            AdminUsersForm f = new AdminUsersForm(LoggedInUser);
            f.Show();
            this.Hide();
        }

        private void btnNavTransactions_Click(object sender, EventArgs e) { }

        private void btnNavLoans_Click(object sender, EventArgs e)
        {
            AdminLoanRequestsForm f = new AdminLoanRequestsForm(LoggedInUser);
            f.Show();
            this.Hide();
        }

        private void btnNavAdminReq_Click(object sender, EventArgs e)
        {
            AdminRequestsForm f = new AdminRequestsForm(LoggedInUser);
            f.Show();
            this.Hide();
        }

        private void btnNavDebitCard_Click(object sender, EventArgs e)
        {
            AdminDebitCardForm f = new AdminDebitCardForm(LoggedInUser);
            f.Show();
            this.Hide();
        }

        private void btnNavBankStmt_Click(object sender, EventArgs e)
        {
            AdminBankStatementForm f = new AdminBankStatementForm(LoggedInUser);
            f.Show();
            this.Hide();
        }

        private void btnNavLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            dgvTransactions.DataSource = TransactionDl.GetTransactionsByFilterDataTable(dtpFrom.Value, dtpTo.Value, txtUserFilter.Text);
        }
    }
}
