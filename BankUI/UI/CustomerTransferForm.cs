using System;
using System.Windows.Forms;
using BankUI.BL;
using BankUI.DL;
namespace BankUI
{
    public partial class CustomerTransferForm : Form
    {
        public string LoggedInUser { get; set; }
        public CustomerTransferForm(string user)
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

        private void btnNavTransfer_Click(object sender, EventArgs e) { }

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
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtAmount.Text, out double amount))
            {
                User senderUser = UserDl.GetUser(LoggedInUser);
                if (senderUser.GetBalance() >= amount)
                {
                    User receiverUser = UserDl.GetUser(txtReceiver.Text);
                    if (receiverUser != null)
                    {
                        senderUser.Withdraw(amount);
                        receiverUser.Deposit(amount);
                        
                        // Persist changes to DB
                        UserDl.UpdateBalance(senderUser.GetUsername(), senderUser.GetBalance());
                        UserDl.UpdateBalance(receiverUser.GetUsername(), receiverUser.GetBalance());
                        
                        Transaction tx = new Transaction(senderUser, receiverUser, amount, DateTime.Now);
                        TransactionDl.AddTransaction(tx);
                        lblStatus.Text = "Transfer Successful";
                        MessageBox.Show("Transfer Successful");
                    }
                    else { MessageBox.Show("Receiver not found"); }
                }
                else { MessageBox.Show("Insufficient balance"); }
            }
            else { MessageBox.Show("Please enter a valid amount"); }
        }
    }
}
