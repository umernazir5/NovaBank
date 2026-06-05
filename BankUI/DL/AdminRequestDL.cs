using BankUI.BL;
using System;
using System.Collections.Generic;
using System.Data;

namespace BankUI.DL
{
    public class AdminRequestDl
    {
        private static List<AdminRequest> adminRequestsList = null;

        public static List<AdminRequest> AdminRequestsList
        {
            get
            {
                if (adminRequestsList == null) adminRequestsList = GetAllRequests();
                return adminRequestsList;
            }
        }

        public static void AddRequest(AdminRequest request)
        {
            string query = $"INSERT INTO admin_requests (username, status) VALUES ('{request.GetUsername()}', '{request.GetStatus()}')";
            DbHelper.ExecuteNonQuery(query);
            adminRequestsList = null;
        }

        public static List<AdminRequest> GetAllRequests()
        {
            List<AdminRequest> list = new List<AdminRequest>();
            string query = "SELECT * FROM admin_requests";
            DataTable dt = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new AdminRequest(
                    int.Parse(row["request_id"].ToString()),
                    row["username"].ToString(),
                    row["status"].ToString()
                ));
            }
            return list;
        }

        public static List<AdminRequest> GetRequestsByStatus(string status)
        {
            List<AdminRequest> filtered = new List<AdminRequest>();
            foreach (AdminRequest req in AdminRequestsList)
            {
                if (req.GetStatus() == status)
                    filtered.Add(req);
            }
            return filtered;
        }

        public static AdminRequest GetPendingRequest(string username)
        {
            foreach (AdminRequest req in AdminRequestsList)
            {
                if (req.GetUsername() == username && req.GetStatus() == "Pending")
                    return req;
            }
            return null;
        }

        public static void UpdateRequestStatus(int requestId, string newStatus)
        {
            string query = $"UPDATE admin_requests SET status = '{newStatus}' WHERE request_id = {requestId}";
            DbHelper.ExecuteNonQuery(query);
            adminRequestsList = null;
        }

        public static void ProcessAdminRequest(int requestId, string username, string newStatus)
        {
            string updateRequestQuery = $"UPDATE admin_requests SET status = '{newStatus}' WHERE request_id = {requestId}";
            DbHelper.ExecuteNonQuery(updateRequestQuery);

            if (newStatus == "Approved")
            {
                string updateUserRoleQuery = $"UPDATE users SET userrole = 'Admin' WHERE username = '{username}'";
                DbHelper.ExecuteNonQuery(updateUserRoleQuery);
            }
            else
            {
                string updateUserRoleQuery = $"UPDATE users SET userrole = 'Customer' WHERE username = '{username}'";
                DbHelper.ExecuteNonQuery(updateUserRoleQuery);
            }
        }

        public static DataTable GetAllRequestsDataTable()
        {
            return DbHelper.ExecuteQuery("SELECT * FROM admin_requests");
        }
        public static bool HasAnyRequest(string username)
        {
            string query = $"SELECT * FROM admin_requests WHERE username = '{username}'";
            DataTable dt = DbHelper.ExecuteQuery(query);
            return dt.Rows.Count > 0;
        }
    }
}
