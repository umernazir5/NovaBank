using System;
using System.Windows.Forms;
using BankUI.BL;
using BankUI.DL;
namespace BankUI
{
    public partial class SignUpForm : Form
    {
        public string LoggedInUser { get; set; }
        public SignUpForm() { InitializeComponent(); }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                lblError.Text = "Passwords do not match";
                MessageBox.Show("Passwords do not match");
                return;
            }
            User user = new User(txtUsername.Text, txtPassword.Text, "Customer", 0);
            UserDl.AddUser(user);
            MessageBox.Show("Registration successful!");
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
        private void llbLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
