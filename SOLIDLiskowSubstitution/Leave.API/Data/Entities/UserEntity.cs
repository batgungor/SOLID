namespace Leave.API.Data.Entities
{
    public class UserEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public LeaveInformationsEntity LeaveInformations { get; set; }
        public decimal Salary => (DailySalary * 30) - LeaveExpenseForSalay;
        public decimal DailySalary { get; set; }
        public decimal LeaveExpenseForSalay { get; set; }
    }
}
