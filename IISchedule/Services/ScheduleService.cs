using Newtonsoft.Json;
using IISchedule.Models.GroupSchedule;
using IISchedule.Models.EmployeeSchedule;
using IISchedule.Models.AllGroupsList;
using IISchedule.Models.AllEmployeesList;
using IISchedule.Models.AllFacultiesList;
using IISchedule.Models.AllDepartmentsList;
using IISchedule.Models.AllSpecializationsList;
using IISchedule.Models.AllCurEmployeesAnnouncements;

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
        public async Task<List<AllGroupsList>> GetAllGroups()
        {
            var Items = new List<AllGroupsList>();
            Uri uri = new Uri("https://iis.bsuir.by/api/v1/student-groups");
            HttpResponseMessage response = await _httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<List<AllGroupsList>>(responseContent);
            }
            else
            {
                Items = null;
            }
            return Items;
        }

        public async Task<List<AllEmployeesList>> GetAllEmployees()
        {
            var Items = new List<AllEmployeesList>();
            Uri uri = new Uri("https://iis.bsuir.by/api/v1/employees/all");
            HttpResponseMessage response = await _httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<List<AllEmployeesList>>(responseContent);
            }
            else
            {
                Items = null;
            }
            return Items;
        }

        public async Task<List<AllFacultiesList>> GetAllFaculties()
        {
            var Items = new List<AllFacultiesList>();
            Uri uri = new Uri("https://iis.bsuir.by/api/v1/faculties");
            HttpResponseMessage response = await _httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<List<AllFacultiesList>>(responseContent);
            }
            else
            {
                Items = null;
            }
            return Items;
        }

        public async Task<List<AllDepartmentsList>> GetAllDepartments()
        {
            var Items = new List<AllDepartmentsList>();
            Uri uri = new Uri("https://iis.bsuir.by/api/v1/departments");
            HttpResponseMessage response = await _httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<List<AllDepartmentsList>>(responseContent);
            }
            else
            {
                Items = null;
            }
            return Items;
        }

        public async Task<List<AllSpecializationsList>> GetAllSpecializations()
        {
            var Items = new List<AllSpecializationsList>();
            Uri uri = new Uri("https://iis.bsuir.by/api/v1/specialities");
            HttpResponseMessage response = await _httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<List<AllSpecializationsList>>(responseContent);
            }
            else
            {
                Items = null;
            }
            return Items;
        }
        public async Task<List<AllCurEmployeesAnnouncements>> GetCurEmployeesAnnouncements(string urlId)
        {
            var Items = new List<AllCurEmployeesAnnouncements>();
            Uri uri = new Uri($"https://iis.bsuir.by/api/v1/specialities?url-id={urlId}");
            HttpResponseMessage response = await _httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<List<AllCurEmployeesAnnouncements>>(responseContent);
            }
            else
            {
                Items = null;
            }
            return Items;
        }
    }
}