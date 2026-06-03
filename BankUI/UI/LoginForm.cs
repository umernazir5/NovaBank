using System;
using System.Windows.Forms;
using BankUI.BL;
using BankUI.DL;

namespace BankUI
{
    public partial class LoginForm : Form
    {
        public string LoggedInUser { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            User credentials = new User(txtUsername.Text, txtPassword.Text, "", 0);
            User user = UserDl.SignIn(credentials);
            if (user != null)
            {
                LoggedInUser = user.GetUsername();
                if (user.GetUserRole() == "Admin")
                {
                    AdminDashBoardForm adminDash = new AdminDashBoardForm(LoggedInUser);
                    adminDash.Show();
                }
                else
                {
                    CustomerDashBoardForm customerDash = new CustomerDashBoardForm(LoggedInUser);
                    customerDash.Show();
                }
                this.Hide();
            }
            else
            {
                lblError.Text = "Invalid username or password";
                MessageBox.Show("Invalid username or password");
            }
        }
        private void llbSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            signUp.Show();
            this.Hide();
        }
    }
}
