using API.Data.Entities;

namespace API.Business
{
    public class TokenManager
    {
        public string GetToken(UserEntity user)
        {
            return "TestJWT " + user.UserTitle;
        }
    }
}
