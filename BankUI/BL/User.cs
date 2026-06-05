using System;

namespace BankUI.BL
{
  
    public abstract class User
    {
        private string username;
        private string password;
        private string userrole;
        private double balance;

        protected User(string username, string password, string userrole, double balance)
        {
            this.username = username;
            this.password = password;
            this.userrole = userrole;
            this.balance = balance;
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
