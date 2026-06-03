using BankUI.BL;
using System;
using System.Collections.Generic;
using System.Data;

namespace BankUI.DL
{
    public class TransactionDl
    {
        private static List<Transaction> transactionList = null;

        public static List<Transaction> Transactions
        {
            get
            {
                if (transactionList == null) transactionList = GetAllTransactions();
                return transactionList;
            }
        }

        public static void AddTransaction(Transaction trans)
        {
            string query = $"INSERT INTO transactions (sender, receiver, amount, transaction_date) " +
                           $"VALUES ('{trans.GetSender().GetUsername()}', '{trans.GetReceiver().GetUsername()}', {trans.GetAmount()}, '{trans.GetTransactionDate():yyyy-MM-dd HH:mm:ss}')";
            DbHelper.ExecuteNonQuery(query);
            transactionList = null;
        }

        public static List<Transaction> GetAllTransactions()
        {
            List<Transaction> list = new List<Transaction>();
            string query = "SELECT * FROM transactions";
            DataTable dt = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                User sender = new User(row["sender"].ToString(), "", "", 0);
                User receiver = new User(row["receiver"].ToString(), "", "", 0);
                double amount = double.Parse(row["amount"].ToString());
                DateTime transactionDate = DateTime.Parse(row["transaction_date"].ToString());
                list.Add(new Transaction(sender, receiver, amount, transactionDate));
            }
            return list;
        }

        public static List<Transaction> GetUserTransactions(string username)
        {
            List<Transaction> list = new List<Transaction>();
            string query = $"SELECT * FROM transactions WHERE sender = '{username}' OR receiver = '{username}'";
            DataTable dt = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                User sender = new User(row["sender"].ToString(), "", "", 0);
                User receiver = new User(row["receiver"].ToString(), "", "", 0);
                double amount = double.Parse(row["amount"].ToString());
                DateTime transactionDate = DateTime.Parse(row["transaction_date"].ToString());
                list.Add(new Transaction(sender, receiver, amount, transactionDate));
            }
            return list;
        }
        public static DataTable GetTop5UserTransactions()
        {

            return DbHelper.ExecuteQuery($"SELECT Top 5* FROM transactions ORDER BY transaction_date DESC");
            
        }

        public static DataTable GetTop5UserTransactionsDataTable(string username)
        {
            return DbHelper.ExecuteQuery($"SELECT TOP 5 * FROM transactions WHERE sender = '{username}' OR receiver = '{username}' ORDER BY transaction_date DESC");
        }

        public static DataTable GetTransactionsByDateRangeDataTable(string username, DateTime from, DateTime to)
        {
            return DbHelper.ExecuteQuery($"SELECT * FROM transactions WHERE (sender = '{username}' OR receiver = '{username}') AND transaction_date BETWEEN '{from:yyyy-MM-dd}' AND '{to:yyyy-MM-dd}'");
        }

        public static DataTable GetAllTransactionsDataTable()
        {
            return DbHelper.ExecuteQuery("SELECT * FROM transactions");
        }

        public static DataTable GetTransactionsByFilterDataTable(DateTime from, DateTime to, string userFilter)
        {
            string sql = $"SELECT * FROM transactions WHERE transaction_date BETWEEN '{from:yyyy-MM-dd}' AND '{to:yyyy-MM-dd}'";
            if (!string.IsNullOrEmpty(userFilter)) sql += $" AND (sender LIKE '%{userFilter}%' OR receiver LIKE '%{userFilter}%')";
            return DbHelper.ExecuteQuery(sql);
        }

    }
}
