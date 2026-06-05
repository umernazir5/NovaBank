namespace BankUI.BL
{
    public class Customer : User
    {
        public Customer(string username, string password, double balance) : base(username, password, "Customer", balance)
        { 
        
        }

    }
}
