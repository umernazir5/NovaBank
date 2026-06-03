using System;
using System.Windows.Forms;
using BankUI.BL;
using BankUI.DL;
namespace BankUI
{
    public partial class AdminRequestsForm : Form
    {
        public string LoggedInUser { get; set; }
        public AdminRequestsForm(string user)
        {
            InitializeComponent();
            LoggedInUser = user;
            dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadRequests();
        }
        private void LoadRequests() { dgvRequests.DataSource = AdminRequestDl.GetAllRequestsDataTable(); }
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

        private void btnNavLoans_Click(object sender, EventArgs e)
        {
            AdminLoanRequestsForm f = new AdminLoanRequestsForm(LoggedInUser);
            f.Show();
            this.Hide();
        }

        private void btnNavAdminReq_Click(object sender, EventArgs e) { }

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
            if (dgvRequests.SelectedRows.Count > 0)
            {
                int reqId = int.Parse(dgvRequests.SelectedRows[0].Cells["request_id"].Value.ToString());
                string username = dgvRequests.SelectedRows[0].Cells["username"].Value.ToString();
                AdminRequestDl.ProcessAdminRequest(reqId, username, "Approved");
                MessageBox.Show("Request Approved");
                LoadRequests();
            }
        }
        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvRequests.SelectedRows.Count > 0)
            {
                int reqId = int.Parse(dgvRequests.SelectedRows[0].Cells["request_id"].Value.ToString());
                string username = dgvRequests.SelectedRows[0].Cells["username"].Value.ToString();
                AdminRequestDl.ProcessAdminRequest(reqId, username, "Rejected");
                MessageBox.Show("Request Rejected");
                LoadRequests();
            }
        }
    }
}
