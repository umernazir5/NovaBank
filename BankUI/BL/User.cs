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


    }
}
