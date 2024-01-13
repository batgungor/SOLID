namespace BankAPI.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Account Account { get; set; }
    }
}
