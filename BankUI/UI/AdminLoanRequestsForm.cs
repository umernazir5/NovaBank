using System;
using System.Windows.Forms;
using BankUI.BL;
using BankUI.DL;
namespace BankUI
{
    public partial class AdminLoanRequestsForm : Form
    {
        public string LoggedInUser { get; set; }
        public AdminLoanRequestsForm(string user)
        {
            InitializeComponent();
            LoggedInUser = user;
            dgvLoans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadLoans();
        }
        private void LoadLoans()
        {
            dgvLoans.DataSource = LoanDl.GetAllLoansDataTable();
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

        private void btnNavTransactions_Click(object sender, EventArgs e)
        {
            AdminTransactionsForm f = new AdminTransactionsForm(LoggedInUser);
            f.Show();
            this.Hide();
        }

        private void btnNavLoans_Click(object sender, EventArgs e) { }

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
        private void btnApprove_Click(object sender, EventArgs e)
        {
            string status = dgvLoans.SelectedRows[0].Cells["status"].Value.ToString();
            if(status == "Approved")
            {
                MessageBox.Show("Loan is already approved");
                return;
            }
            if (dgvLoans.SelectedRows.Count > 0)
            {
                int loanId = int.Parse(dgvLoans.SelectedRows[0].Cells["loanid"].Value.ToString());
                LoanDl.UpdateLoanStatus("Approved", loanId);
                MessageBox.Show("Loan Approved");
                LoadLoans();
            }
        }
        private void btnReject_Click(object sender, EventArgs e)
        {
            string status = dgvLoans.SelectedRows[0].Cells["status"].Value.ToString();
            if (status == "Approved")
            {
                MessageBox.Show("Loan is already approved Cant Reject Now");
                return;
            }
            if (dgvLoans.SelectedRows.Count > 0)
            {
                int loanId = int.Parse(dgvLoans.SelectedRows[0].Cells["loanid"].Value.ToString());
                LoanDl.UpdateLoanStatus("Rejected", loanId);
                MessageBox.Show("Loan Rejected");
                LoadLoans();
            }
        }

        private void dgvLoans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
