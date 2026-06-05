using BankUI.BL;
using System.Collections.Generic;
using System.Data;

namespace BankUI.DL
{
    public class UserDl
    {
        private static List<User> usersList = null;

        public static List<User> UsersList
        {
            get
            {
                if (usersList == null) usersList = GetAllUsers();
                return usersList;
            }
        }

        public static void RefreshUsers()
        {
            usersList = null;
        }

        public static User SignIn(User userCredentials)
        {
            string query = $"SELECT * FROM users WHERE username = '{userCredentials.GetUsername()}' AND password = '{userCredentials.GetPassword()}'";
            DataTable dt = DbHelper.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                string role = row["userrole"].ToString();
                string uname = row["username"].ToString();
                string pass = row["password"].ToString();
                double balance = double.Parse(row["balance"].ToString());

                if (role == "Admin")
                {
                    User user = new Admin(uname, pass, balance);
                    return user;
                }
                else
                {
                    User user = new Customer(uname, pass, balance);
                    return user;
                }
            }
            return null;
        }

        public static void AddUser(User user)
        {
            string query = $"INSERT INTO users (username, password, userrole, balance) " +
                           $"VALUES ('{user.GetUsername()}', '{user.GetPassword()}', '{user.GetUserRole()}', {user.GetBalance()})";
            DbHelper.ExecuteNonQuery(query);
            usersList = null;
        }

        public static bool DeleteAccount(string username)
        {
            string query1 = $"DELETE FROM users WHERE username = '{username}'";
            string query2 = $"DELETE FROM debit_cards WHERE username = '{username}'";
            string query3 = $"DELETE FROM admin_requests WHERE username = '{username}'";
            string query4 = $"DELETE FROM loan WHERE username = '{username}'";
            DbHelper.ExecuteNonQuery(query2);
            DbHelper.ExecuteNonQuery(query3);
            DbHelper.ExecuteNonQuery(query4);
            int rowsAffected = DbHelper.ExecuteNonQuery(query1);
            if (rowsAffected > 0) usersList = null;
            return rowsAffected > 0;
        }

        public static User GetUser(string username)
        {
            string query = $"SELECT * FROM users WHERE username = '{username}'";
            DataTable dt = DbHelper.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                string role = row["userrole"].ToString();
                string uname = row["username"].ToString();
                string pass = row["password"].ToString();
                double balance = double.Parse(row["balance"].ToString());

                if (role == "Admin")
                {
                    User user = new Admin(uname, pass, balance);
                    return user;
                }
                else
                {
                    User user = new Customer(uname, pass, balance);
                    return user;
                }
            }
            return null;
        }

        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            string query = "SELECT * FROM users";
            DataTable dt = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                string role = row["userrole"].ToString();
                string uname = row["username"].ToString();
                string pass = row["password"].ToString();
                double balance = double.Parse(row["balance"].ToString());

                if (role == "Admin")
                {
                    User user = new Admin(uname, pass, balance);
                    users.Add(user);
                }
                else
                {
                    User user = new Customer(uname, pass, balance);
                    users.Add(user);
                }
            }
            return users;
        }

        public static void UpdateBalance(string username, double newBalance)
        {
            string query = $"UPDATE users SET balance = {newBalance} WHERE username = '{username}'";
            DbHelper.ExecuteNonQuery(query);
        }

        public static void UpdatePassword(string username, string newPassword)
        {
            string query = $"UPDATE users SET password = '{newPassword}' WHERE username = '{username}'";
            DbHelper.ExecuteNonQuery(query);
            usersList = null;
        }

        public static void UpdateUserRole(string username, string newRole)
        {
            string query = $"UPDATE users SET userrole = '{newRole}' WHERE username = '{username}'";
            DbHelper.ExecuteNonQuery(query);
            usersList = null;
        }

        public static DataTable GetAllUsersDataTable()
        {
            return DbHelper.ExecuteQuery("SELECT * FROM users");
        }

        public static DataTable SearchUsersDataTable(string searchTerm)
        {
            return DbHelper.ExecuteQuery($"SELECT * FROM users WHERE username LIKE '%{searchTerm}%'");
        }

        public static DataTable GetTop5RecentUsersDataTable()
        {
            return DbHelper.ExecuteQuery("SELECT TOP 5 * FROM users ORDER BY username DESC");
        }
    }
}