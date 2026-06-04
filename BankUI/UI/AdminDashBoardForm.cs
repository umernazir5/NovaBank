using System;
using System.Windows.Forms;
using BankUI.BL;
using BankUI.DL;
namespace BankUI
{
    public partial class AdminDashBoardForm : Form
    {
        public string LoggedInUser { get; set; }
        public AdminDashBoardForm(string user)
        {
            InitializeComponent();
            LoggedInUser = user;
            LoadStats();
            dgvRecentTx.DataSource = TransactionDl.GetTop5UserTransactions();
            dgvRecentUsers.DataSource = UserDl.GetTop5RecentUsersDataTable();
        }

        private void LoadStats()
        {
            lblcardUsersV.Text = UserDl.GetAllUsers().Count.ToString();
            lblcardTxV.Text = TransactionDl.GetAllTransactions().Count.ToString();
            lblcardLoansV.Text = LoanDl.GetLoansByStatus("Pending").Count.ToString();
            lblcardCardsV.Text = DebitCardDl.GetAllCards().Count.ToString();
        }
        private void btnNavDashboard_Click(object sender, EventArgs e) { }
        private void btnNavUsers_Click(object sender, EventArgs e)
        {
            AdminUsersForm form = new AdminUsersForm(LoggedInUser);
            form.Show();
            this.Hide();
        }
        private void btnNavTransactions_Click(object sender, EventArgs e)
        {
            AdminTransactionsForm form = new AdminTransactionsForm(LoggedInUser);
            form.Show();
            this.Hide();
        }
        private void btnNavLoans_Click(object sender, EventArgs e)
        {
            AdminLoanRequestsForm form = new AdminLoanRequestsForm(LoggedInUser);
            form.Show();
            this.Hide();
        }
        private void btnNavAdminReq_Click(object sender, EventArgs e)
        {
            AdminRequestsForm form = new AdminRequestsForm(LoggedInUser);
            form.Show();
            this.Hide();
        }
        private void btnNavDebitCard_Click(object sender, EventArgs e)
        {
            AdminDebitCardForm form = new AdminDebitCardForm(LoggedInUser);
            form.Show();
            this.Hide();
        }
        private void btnNavBankStmt_Click(object sender, EventArgs e)
        {
            AdminBankStatementForm form = new AdminBankStatementForm(LoggedInUser);
            form.Show();
            this.Hide();
        }
        private void btnNavLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void lblcardUsersV_Click(object sender, EventArgs e)
        {
            int totalusers = UserDl.GetAllUsers().Count;

        }

        private void lblcardCardsV_Click(object sender, EventArgs e)
        {

        }
    }
}
