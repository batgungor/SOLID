using Leave.API.Data.Entities;

namespace Leave.API.Data
{
    public class MockDataBase
    {
        private List<UserEntity> _users;
        public MockDataBase()
        {
            _users = new List<UserEntity>()
            {
                new UserEntity()
                {
                    Id = "User1",
                    Name = "Batuhan Güngör",
                    DailySalary = 100,
                    LeaveInformations = new LeaveInformationsEntity()
                    {
                        AnnualLeave = new LeaveEntity()
                        {
                            TotalLeaveRights = 10,
                            UsedDays = 5
                        },
                        ExcusedLeave = new LeaveEntity()
                        {
                            TotalLeaveRights = 3,
                            UsedDays = 1
                        }
                    }
                },
                new UserEntity()
                {
                    Id = "User2",
                    Name = "Dilan Güngör",
                    DailySalary = 200,
                    LeaveInformations = new LeaveInformationsEntity()
                    {
                        AnnualLeave = new LeaveEntity()
                        {
                            TotalLeaveRights = 10,
                            UsedDays = 8
                        },
                        ExcusedLeave = new LeaveEntity()
                        {
                            TotalLeaveRights = 3,
                            UsedDays = 0
                        }
                    }
                }
            };
        }

        public UserEntity GetUser(string id)
        {
            var user = _users.FirstOrDefault(q => q.Id == id);
            return user;
        }
    }
}
