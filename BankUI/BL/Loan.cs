using BankUI.DL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankUI.BL
{
    public class Loan
    {
        private int id;
        private User user;
        private double amount;
        private string status;

        public Loan(User user, double amount)
        {
            this.user = user;
            this.amount = amount;
            this.status = "Pending";
        }

        public Loan(int id, User user, double amount, string status)
        {
            this.id = id;
            this.user = user;
            this.amount = amount;
            this.status = status;
        }

        public int GetId()
        {
            return id;
        }

        public User GetUser()
        {
            return user;
        }

        public double GetAmount()
        {
            return amount;
        }

        public string GetStatus()
        {
            return status;
        }
 
    }
}
