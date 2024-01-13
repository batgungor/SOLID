using System.Net.Http;

namespace Application
{
    public class CampaingService
    {
        private readonly HttpClient _httpClient;
        public CampaingService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
    }
}
