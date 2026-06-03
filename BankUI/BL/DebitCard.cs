using BankUI.DL;
using System;

namespace BankUI.BL
{
    public class DebitCard
    {
        private string cardNumber;
        private string username;
        private string cvc;
        private DateTime expiryDate;

        public DebitCard(string cardNumber, string username, string cvc, DateTime expiryDate)
        {
            this.cardNumber = cardNumber;
            this.username = username;
            this.cvc = cvc;
            this.expiryDate = expiryDate;
        }

        public DebitCard(User user)
        {
            this.username = user.GetUsername();
            this.cardNumber = GenerateCardNumber();
            this.cvc = GenerateCVC();
            this.expiryDate = GenerateExpiryDate();

            user.Withdraw(500);
            UserDl.UpdateBalance(user.GetUsername(), user.GetBalance());
            DebitCardDl.AddDebitCard(this);
        }
        public string GetCardNumber()
        {
            return this.cardNumber;
        }
        public string GetUsername()
        {
            return this.username;
        }
        public string GetCvc()
        {
            return this.cvc;
        }
        public DateTime GetExpiryDate()
        {
            return this.expiryDate;
        }

        private static string GenerateCardNumber()
        {
            Random rand = new Random();
            string number = "";
            for (int i = 0; i < 16; i++)
                number += rand.Next(0, 10).ToString();
            return number;
        }

        private static string GenerateCVC()
        {
            return new Random().Next(100, 999).ToString();
        }

        private static DateTime GenerateExpiryDate()
        {
            return DateTime.Now.AddYears(3);
        }

        public static bool HasSufficientBalance(User user)
        {
            return user.GetBalance() >= 500;
        }

    }
}
