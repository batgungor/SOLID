using BankAPI.Models;

namespace BankAPI.Services
{
    public class UserManager
    {
        public User CreateUser()
        {
            var user = new User()
            {
                Id = Guid.NewGuid(),
                Name = "Batuhan Güngör"
            };

            //user.Account = CreateUserAccount();
            return user;
        }

        /*
        private Account CreateUserAccount()
        {
            var account = new Account()
            {
                Name = "Bank Account 1",
                Balance = 100
            };
            return account;
        }
        */
    }
}
