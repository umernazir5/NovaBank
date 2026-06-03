using System;
using System.Windows.Forms;
using BankUI.BL;
using BankUI.DL;
namespace BankUI
{
    public partial class AdminUsersForm : Form
    {
        public string LoggedInUser { get; set; }
        public AdminUsersForm(string user)
        {
            InitializeComponent();
            LoggedInUser = user;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadUsers();
        }
        private void LoadUsers() { dgvUsers.DataSource = UserDl.GetAllUsersDataTable(); }
        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            AdminDashBoardForm f = new AdminDashBoardForm(LoggedInUser);
            f.Show();
            this.Hide();
        }

        private void btnNavUsers_Click(object sender, EventArgs e) { }

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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadUsers();
            }
            else
            {
                dgvUsers.DataSource = UserDl.SearchUsersDataTable(txtSearch.Text);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                string username = dgvUsers.SelectedRows[0].Cells["username"].Value.ToString();
                UserDl.DeleteAccount(username);
                MessageBox.Show("User deleted successfully");
                LoadUsers();
            }
        }
        private void btnUpdatePwd_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                string username = dgvUsers.SelectedRows[0].Cells["username"].Value.ToString();
                string newPwd = PromptForPassword("Update Password", $"Enter new password for {username}:");
                if (!string.IsNullOrEmpty(newPwd))
                {
                    UserDl.UpdatePassword(username, newPwd);
                    MessageBox.Show("Password updated successfully");
                    LoadUsers();
                }
            }
            else
            {
                MessageBox.Show("Please select a user first");
            }
        }

        private string PromptForPassword(string title, string promptText)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            form.ClientSize = new System.Drawing.Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            return dialogResult == DialogResult.OK ? textBox.Text : "";
        }
    }
}
