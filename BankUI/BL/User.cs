using System;
using BankUI.DL;

namespace BankUI.BL
{
    public class User
    {
        private string username;
        private string password;
        private string userrole;
        private double balance;

        public User(string username, string password, string userrole, double balance)
        {
            this.username = username;
            this.password = password;
            this.userrole = userrole;
            this.balance = balance;
        }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.userrole = "Customer";
            this.balance = 0.0;
        }

        public string GetUsername()
        {
            return this.username;
        }
        public string GetPassword()
        {
            return this.password;
        }
        public string GetUserRole()
        {
            return this.userrole;
        }
        public double GetBalance()
        {
            return this.balance;
        }
        public bool IsAdmin()
        {
            if (userrole == "Admin")
            {
                return true;
            }
            return false;
        }
        public bool IsCustomer()
        {
            if (userrole == "Customer")
            {
                return true;
            }
            return false;
        }
        public bool Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                return true;
            }
            return false;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }
        public double checkBalance()
        {
            return balance;
        }
        public static User VerifyUser(string username, string password)
        {
            User found = UserDl.GetUser(username);
            if (found == null || password != found.GetPassword())
                return null;
            return found;
        }
        public bool TryWithdraw(double amount)
        {
            if (!Withdraw(amount)) return false;
            UserDl.UpdateBalance(username, balance);
            return true;
        }

        public void DepositAndSave(double amount)
        {
            Deposit(amount);
            UserDl.UpdateBalance(username, balance);
        }
        public static bool AdminDeleteAccount(string username)
        {
            User target = UserDl.GetUser(username);
            if (target == null) return false;
            return UserDl.DeleteAccount(target.GetUsername());
        }

        public static bool SelfDeleteAccount(string username, string password)
        {
            User verified = VerifyUser(username, password);
            if (verified == null) return false;
            return UserDl.DeleteAccount(verified.GetUsername());
        }

        public static bool AdminUpdatePassword(string username, string newPassword)
        {
            User target = UserDl.GetUser(username);
            if (target == null) return false;
            UserDl.UpdatePassword(username, newPassword);
            return true;
        }
    }
}
