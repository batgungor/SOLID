using BankAPI.Models;

namespace BankAPI.Services
{
    public class AccountManager
    {
        public Account CreateAccount()
        {
            var account = new Account()
            {
                Name = "Bank Account 1",
                Balance = 100
            };
            return account;
        }
    }
}
