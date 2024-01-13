using API.Business.Leave.Models;
using API.Data.Entities;
using System.Text;

namespace API.Business.Leave.Management.LeaveOperators
{
    public class SickLeaveOperator : LeaveOpeator
    {
        private readonly HttpClient _httpClient;
        public SickLeaveOperator()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://sgksistemi.com");
        }
        public override void Create(CreateLeaveModel request, User user)
        {
            CheckLeaveRight(user.LeaveInformations.ExcusedLeave, request.RequestedDayCount);

            user.LeaveInformations.ExcusedLeave.UsedDays += request.RequestedDayCount;

            var stringPayload = "TcNo = 12345678910, GunSayisi = request.RequestedDayCount";
            var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");

            _httpClient.PostAsync("izingiris", httpContent);
        }
    }
}
