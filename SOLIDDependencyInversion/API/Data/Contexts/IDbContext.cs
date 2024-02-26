using API.Data.Entities;

namespace API.Data.Contexts
{
    public interface IDbContext
    {
        public List<UserEntity> Users { get; }
    }
}
