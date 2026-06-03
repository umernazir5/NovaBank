using BankUI.DL;
using System;
using System.Collections.Generic;

namespace BankUI.BL
{
    public class AdminRequest
    {
        private int requestId;
        private string username;
        private string status;

        public AdminRequest(string username)
        {
            this.username = username;
            this.status = "Pending";
        }

        public AdminRequest(int requestId, string username, string status)
        {
            this.requestId = requestId;
            this.username = username;
            this.status = status;
        }

        public int GetRequestId()
        {
            return requestId;
        }
        public string GetUsername()
        {
            return username;
        }
        public string GetStatus()
        {
            return status;
        }
        public static bool SubmitRequest(string username, string password)
        {
            User verified = User.VerifyUser(username, password);
            if (verified == null) return false;
            if (verified.IsAdmin()) return false;

            AdminRequest existing = AdminRequestDl.GetPendingRequest(verified.GetUsername());
            if (existing != null) return false;

            AdminRequestDl.AddRequest(new AdminRequest(verified.GetUsername()));
            return true;
        }

        public static bool HasPendingRequest(string username)
        {
            return AdminRequestDl.GetPendingRequest(username) != null;
        }

        public static bool ProcessRequest(int requestId, string newStatus)
        {
            List<AdminRequest> pending = AdminRequestDl.GetRequestsByStatus("Pending");
            AdminRequest target = pending.Find(r => r.GetRequestId() == requestId);
            if (target == null) return false;

            AdminRequestDl.ProcessAdminRequest(requestId, target.GetUsername(), newStatus);
            return true;
        }

        public static List<AdminRequest> GetByStatus(string status)
        {
            return AdminRequestDl.GetRequestsByStatus(status);
        }
    }
}

