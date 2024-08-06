using Newtonsoft.Json;
using IISchedule.Models.GroupSchedule;
using IISchedule.Models.EmployeeSchedule;

namespace IISchedule.Services
{
    class ScheduleService : IScheduleService
    {
        private readonly HttpClient _httpClient;

        public ScheduleService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GroupSchedule> GetGroupSchedule(String groupName)
        {
            var Items = new GroupSchedule();
            Uri uri = new Uri($"https://iis.bsuir.by/api/v1/schedule?studentGroup={groupName}");
            HttpResponseMessage response = await _httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<GroupSchedule>(responseContent);
            }
            else 
            {
                Items = null;
            }
            return Items;
        }

        public async Task<EmployeeSchedule> GetEmployeeSchedule(string urlId)
        {
            var Items = new EmployeeSchedule();
            Uri uri = new Uri($"https://iis.bsuir.by/api/v1/employees/schedule/{urlId}");
            HttpResponseMessage response = await _httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<EmployeeSchedule>(responseContent);
            }
            else
            {
                Items = null;
            }
            return Items;
        }
    }
}