using API.Data.Entities;

namespace API.Data
{
    public class MockDataBase
    {
        private List<User> _users;
        public MockDataBase()
        {
            _users = new List<User>()
            {
                new User()
                {
                    Id = "User1",
                    Name = "Batuhan Güngör",
                    DailySalary = 100,
                    LeaveInformations = new LeaveInformations()
                    {
                        AnnualLeave = new Leave()
                        {
                            TotalLeaveRights = 10,
                            UsedDays = 5
                        },
                        ExcusedLeave = new Leave()
                        {
                            TotalLeaveRights = 3,
                            UsedDays = 1
                        }
                    }
                },
                new User()
                {
                    Id = "User2",
                    Name = "Dilan Güngör",
                    DailySalary = 200,
                    LeaveInformations = new LeaveInformations()
                    {
                        AnnualLeave = new Leave()
                        {
                            TotalLeaveRights = 10,
                            UsedDays = 8
                        },
                        ExcusedLeave = new Leave()
                        {
                            TotalLeaveRights = 3,
                            UsedDays = 0
                        }
                    }
                }
            };
        }

        public User GetUser(string id)
        {
            var user = _users.FirstOrDefault(q => q.Id == id);
            return user;
        }
    }
}
