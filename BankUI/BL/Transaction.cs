using BankUI.DL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankUI.BL
{
    public class Transaction
    {
        private User sender;
        private User receiver;
        private double amount;
        private DateTime transactionDate;

        public Transaction(User sender, User receiver, double amount)
        {
            this.sender = sender;
            this.receiver = receiver;
            this.amount = amount;
            this.transactionDate = DateTime.Now;
        }

        public Transaction(User sender, User receiver, double amount, DateTime transactionDate)
        {
            this.sender = sender;
            this.receiver = receiver;
            this.amount = amount;
            this.transactionDate = transactionDate;
        }

        public User GetSender()
        {
            return sender;
        }

        public User GetReceiver()
        {
            return receiver;
        }

        public double GetAmount()
        {
            return amount;
        }

        public DateTime GetTransactionDate()
        {
            return transactionDate;
        }

        public bool Process()
        {

            if (amount > 0 && sender.Withdraw(amount))
            {
                receiver.Deposit(amount);
                return true;
            }
            return false;
        }

        public static bool Transfer(string senderName, string receiverName, double amount)
        {
            User sender = UserDl.GetUser(senderName);
            User receiver = UserDl.GetUser(receiverName);

            if (sender == null || receiver == null) return false;

            Transaction txn = new Transaction(sender, receiver, amount);
            if (!txn.Process()) return false;

            UserDl.UpdateBalance(sender.GetUsername(), sender.GetBalance());
            UserDl.UpdateBalance(receiver.GetUsername(), receiver.GetBalance());
            TransactionDl.AddTransaction(txn);
            return true;
        }
    }
}

