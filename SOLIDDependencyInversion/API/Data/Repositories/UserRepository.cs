using API.Data.Contexts;
using API.Data.Entities;

namespace API.Data.Repositories
{
    public class UserRepository
    {
        //private readonly StaticDbContext _dbContext;
        private readonly IDbContext _dbContext;

        //public UserRepository(StaticDbContext dbContext)
        public UserRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public UserEntity GetUser(string userName, string password)
        {
            //var _dbContext = new DbContext();
            var user = _dbContext.Users.FirstOrDefault(q => 
                q.UserName == userName && 
                q.Password == password);
            return user;
        }
    }
}
