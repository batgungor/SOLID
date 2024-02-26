using API.Data.Entities;
using API.Data.Repositories;

namespace API.Business
{
    public class UserService
    {
        private readonly UserRepository _userRepository;
        public UserService(UserRepository userRepository)
        {
                _userRepository = userRepository;
        }

        public UserEntity CheckUserLogin(string userName, string password)
        {
            //var _userRepository = new UserRepository();
            var user = _userRepository.GetUser(userName, password);

            //Middleware üzerinden loglamak istersek
            ArgumentNullException.ThrowIfNull(user);
            return user;
        }
    }
}
