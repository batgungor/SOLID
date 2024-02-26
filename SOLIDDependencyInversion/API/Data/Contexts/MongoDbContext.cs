using API.Data.Entities;

namespace API.Data.Contexts
{
    public class MongoDbContext : IDbContext
    {
        public List<UserEntity> Users => new()
        {
            new UserEntity()
            {
                Id = 1,
                UserName = "TestUser1",
                Password = "TestPassword1",
                UserTitle = "MongoDBUser"
            }
        };
    }
}
