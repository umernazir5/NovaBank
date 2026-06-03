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
        public static bool RequestLoan(string username, string password, double amount)
        {
            User verified = User.VerifyUser(username, password);
            if (verified == null) return false;

            LoanDl.AddLoan(new Loan(verified, amount));
            return true;
        }

        public static bool ProcessLoan(int loanId, string newStatus)
        {
            List<Loan> pending = LoanDl.GetLoansByStatus("Pending");
            bool found = false;
            foreach (Loan l in pending)
            {
                if (l.GetId() == loanId)
                {
                    found = true;
                    break;
                }
            }
            if (!found) return false;

            LoanDl.UpdateLoanStatus(newStatus, loanId);
            return true;
        }

        public static List<Loan> GetByStatus(string status)
        {
            return LoanDl.GetLoansByStatus(status);
        }
    }
}
