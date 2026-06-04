using System;
using System.Windows.Forms;
using BankUI.BL;
using BankUI.DL;
namespace BankUI
{
    public partial class CustomerDashBoardForm : Form
    {
        public string LoggedInUser { get; set; }
        public CustomerDashBoardForm(string user)
        {
            InitializeComponent();
            LoggedInUser = user;
            User u = UserDl.GetUser(LoggedInUser);
            lblBalance.Text = $"Balance: Rs : {u.GetBalance()}";
            dgvRecentTx.DataSource = TransactionDl.GetTop5UserTransactionsDataTable(LoggedInUser);
        }
        private void btnNavDashboard_Click(object sender, EventArgs e) { }

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
        private void btnQuickTransfer_Click(object sender, EventArgs e) { btnNavTransfer_Click(sender, e); }
        private void btnQuickLoan_Click(object sender, EventArgs e) { btnNavLoan_Click(sender, e); }
        private void btnQuickCard_Click(object sender, EventArgs e) { btnNavDebitCard_Click(sender, e); }
        private void btnQuickStmt_Click(object sender, EventArgs e) { btnNavBankStmt_Click(sender, e); }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }
    }
}
