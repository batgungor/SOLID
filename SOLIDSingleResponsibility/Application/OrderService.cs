using Application.Models;
using System.Net.Http;

namespace Application
{
    public class OrderService
    {
        private readonly HttpClient _httpClient;
        public OrderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<Order> GetOrders(User user)
        {
            var orders = new List<Order>()
            {
                new Order() { OrderNumber = "Order1"}
            };
            return orders;
        }
    }
}
