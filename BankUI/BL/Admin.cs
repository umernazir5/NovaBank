namespace BankUI.BL
{
    public class Admin : User
    {
        public Admin(string username, string password, double balance): base(username, password, "Admin", balance)
        { 
        
        }


    }
}
