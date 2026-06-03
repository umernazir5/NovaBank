using System;
using System.Windows.Forms;
using BankUI.BL;
using BankUI.DL;
namespace BankUI
{
    public partial class CustomerCheckBalanceForm : Form
    {
        public string LoggedInUser { get; set; }
        public CustomerCheckBalanceForm(string user)
        {
            InitializeComponent();
            LoggedInUser = user;
            UpdateBalanceDisplay();
        }

        private void UpdateBalanceDisplay()
        {
            User u = UserDl.GetUser(LoggedInUser);
            lblBalance.Text = $"Rs. {u.GetBalance():N2}";
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
        private void btnNavDebitCard_Click(object sender, EventArgs e) { CustomerApplyDebitCardForm f = new CustomerApplyDebitCardForm(LoggedInUser); f.Show(); this.Hide(); }
        private void btnNavLoan_Click(object sender, EventArgs e) { CustomerLoanRequestForm f = new CustomerLoanRequestForm(LoggedInUser); f.Show(); this.Hide(); }
        private void btnNavAdminReq_Click(object sender, EventArgs e) { CustomerApplyAdminForm f = new CustomerApplyAdminForm(LoggedInUser); f.Show(); this.Hide(); }
        private void btnNavBalance_Click(object sender, EventArgs e) { }
        private void btnNavBankStmt_Click(object sender, EventArgs e) { CustomerBankStatementForm f = new CustomerBankStatementForm(LoggedInUser); f.Show(); this.Hide(); }
        private void btnNavLogout_Click(object sender, EventArgs e) { LoginForm login = new LoginForm(); login.Show(); this.Hide(); }

        private void lblBalance_Click(object sender, EventArgs e) { }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtAmount.Text, out double amount) && amount > 0)
            {
                User u = UserDl.GetUser(LoggedInUser);
                double newBalance = u.GetBalance() + amount;
                
              
                UserDl.UpdateBalance(LoggedInUser, newBalance);
                UpdateBalanceDisplay();
                txtAmount.Clear();
                MessageBox.Show("Successfully deposited", "Deposit Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a valid positive amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
