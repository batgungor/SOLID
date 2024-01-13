using Application.Models;

namespace Application
{
    public class UserService
    {
        private readonly HttpClient _httpClient;
        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public User GetUser(string userId)
        {
            return new User();
        }
    }
}
