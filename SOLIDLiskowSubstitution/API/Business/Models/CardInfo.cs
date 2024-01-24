namespace API.Business.Models
{
    public class CardInfo
    {
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public string CVV { get; set; }
        public int ExpireMonth { get; set; }
        public int ExpireYear{ get; set; }
    }
}
