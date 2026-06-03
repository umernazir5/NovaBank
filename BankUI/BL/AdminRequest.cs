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

    }
}

