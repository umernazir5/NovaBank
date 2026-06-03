using System;
using System.Windows.Forms;
using BankUI.BL;
using BankUI.DL;
namespace BankUI
{
    public partial class CustomerApplyDebitCardForm : Form
    {
        public string LoggedInUser { get; set; }
        public CustomerApplyDebitCardForm(string user)
        {
            InitializeComponent();
            LoggedInUser = user;
            DebitCard card = DebitCardDl.GetUserCard(LoggedInUser);
            if (card != null)
            {
                lblCardNumber.Text = card.GetCardNumber();
                lblCardHolder.Text = card.GetUsername();
                lblCardExpiry.Text = card.GetExpiryDate().ToString("MM/yy");
                btnApply.Enabled = false;
            }
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

        private void btnNavDebitCard_Click(object sender, EventArgs e) { }

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
        private void btnApply_Click(object sender, EventArgs e)
        {
           
            User currentUser = UserDl.GetUser(LoggedInUser);
            if (DebitCard.HasSufficientBalance(currentUser))
            {
                DebitCard card = new DebitCard(currentUser);
                lblCardNumber.Text = card.GetCardNumber();
                lblCardHolder.Text = card.GetUsername();
                lblCardExpiry.Text = card.GetExpiryDate().ToString("MM/yy");
                lblStatus.Text = "Card Applied Successfully";
                btnApply.Enabled = false;
                MessageBox.Show("Debit Card Issued Successfully! 500 has been deducted from your account.");
            }
            else
            {
                MessageBox.Show("Insufficient balance! You need at least 500 to apply for a card.");
            }
        }
    }
}
