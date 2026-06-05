using BankUI.BL;
using System.Collections.Generic;
using System.Data;

namespace BankUI.DL
{
    public class LoanDl
    {
        private static List<Loan> loansList = null;

        public static List<Loan> LoansList
        {
            get
            {
                if (loansList == null) loansList = GetAllLoans();
                return loansList;
            }
        }

        public static void AddLoan(Loan loan)
        {
            string query = $"INSERT INTO loan (username, amount, status) " +
                           $"VALUES ('{loan.GetUser().GetUsername()}', {loan.GetAmount()}, '{loan.GetStatus()}')";
            DbHelper.ExecuteNonQuery(query);
            loansList = null;
        }

        public static List<Loan> GetAllLoans()
        {
            List<Loan> loans = new List<Loan>();
            string query = "SELECT * FROM loan";
            DataTable dt = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                int id = int.Parse(row["loanid"].ToString());
                User user = new Customer(row["username"].ToString(), "", 0);
                double amount = double.Parse(row["amount"].ToString());
                string status = row["status"].ToString();
                loans.Add(new Loan(id, user, amount, status));
            }
            return loans;
        }

        public static List<Loan> GetLoansByStatus(string status)
        {
            List<Loan> loans = new List<Loan>();
            string query = $"SELECT * FROM loan WHERE status = '{status}'";
            DataTable dt = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                int id = int.Parse(row["loanid"].ToString());
                User user = new Customer(row["username"].ToString(), "", 0);
                double amount = double.Parse(row["amount"].ToString());
                string rowStatus = row["status"].ToString();
                loans.Add(new Loan(id, user, amount, rowStatus));
            }
            return loans;
        }
        public static void UpdateLoanStatus(string newStatus, int loanId)
        {
            string query = $"UPDATE loan SET status = '{newStatus}' WHERE loanid = {loanId}";
            DbHelper.ExecuteNonQuery(query);

            if (newStatus == "Approved")
            {
                foreach (Loan loan in GetAllLoans())
                {
                    if (loan.GetId() == loanId)
                    {
                        User targetUser = UserDl.GetUser(loan.GetUser().GetUsername());
                        if (targetUser != null)
                        {
                            targetUser.Deposit(loan.GetAmount());
                            UserDl.UpdateBalance(targetUser.GetUsername(), targetUser.GetBalance());
                        }
                        break;
                    }
                }
            }

            loansList = null;
        }

        public static DataTable GetAllLoansDataTable()
        {
            return DbHelper.ExecuteQuery("SELECT * FROM loan");
        }
    }
}