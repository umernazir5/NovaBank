using BankUI.BL;
using System;
using System.Collections.Generic;
using System.Data;

namespace BankUI.DL
{
    public class DebitCardDl
    {
        private static List<DebitCard> debitCardsList = null;

        public static List<DebitCard> DebitCards
        {
            get
            {
                if (debitCardsList == null) debitCardsList = GetAllCards();
                return debitCardsList;
            }
        }

        public static void AddDebitCard(DebitCard card)
        {
            string formattedDate = card.GetExpiryDate().ToString("yyyy-MM-dd");
            string query = $"INSERT INTO debit_cards (card_number, username, cvc, expiry_date) " +
                           $"VALUES ('{card.GetCardNumber()}', '{card.GetUsername()}', '{card.GetCvc()}', '{formattedDate}')";
            DbHelper.ExecuteNonQuery(query);
            debitCardsList = null;
        }

        public static DebitCard GetUserCard(string username)
        {
            string query = $"SELECT * FROM debit_cards WHERE username = '{username}'";
            DataTable dt = DbHelper.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new DebitCard(
                    row["card_number"].ToString(),
                    row["username"].ToString(),
                    row["cvc"].ToString(),
                    Convert.ToDateTime(row["expiry_date"])
                );
            }
            return null;
        }

        public static List<DebitCard> GetAllCards()
        {
            List<DebitCard> list = new List<DebitCard>();
            string query = "SELECT * FROM debit_cards";
            DataTable dt = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DebitCard(
                    row["card_number"].ToString(),
                    row["username"].ToString(),
                    row["cvc"].ToString(),
                    Convert.ToDateTime(row["expiry_date"])
                ));
            }
            return list;
        }

        public static DataTable GetAllDebitCardsDataTable()
        {
            return DbHelper.ExecuteQuery("SELECT * FROM debit_cards");
        }
    }
}
