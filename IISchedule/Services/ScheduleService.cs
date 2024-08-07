using Newtonsoft.Json;
using IISchedule.Validations;
using IISchedule.Models.GroupSchedule;
using IISchedule.Models.EmployeeSchedule;
using IISchedule.Models.AllGroupsList;
using IISchedule.Models.AllEmployeesList;
using IISchedule.Models.AllFacultiesList;
using IISchedule.Models.AllDepartmentsList;
using IISchedule.Models.AllSpecializationsList;
using IISchedule.Models.AllCurEmployeesAnnouncements;
using IISchedule.Models.AllRelevantDepartmentAnnouncements;
using IISchedule.Models.AllAudiencesList;
using IISchedule.Models.LastScheduleUpdate;

namespace IISchedule.Services
{
    class ScheduleService : IScheduleService
    {
        private readonly HttpClient _httpClient;

        public ScheduleService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<GroupSchedule> GetGroupSchedule(string groupName)
        {
            var Items = new GroupSchedule();
            Uri uri = new Uri($"https://iis.bsuir.by/api/v1/schedule?studentGroup={groupName}");
            HttpResponseMessage response = await _httpClient.GetAsync(uri);
            if (!response.IsSuccessStatusCode)
            {
                throw new StatusCodeException($"Error with exit code {response.StatusCode}!!!");
            }
            try
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<GroupSchedule>(responseContent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            if (Items == null)
            {
                throw new EmptyItemsConvertException("Empty url.");
            }
            return Items;
        }
        public async Task<EmployeeSchedule> GetEmployeeSchedule(string urlId)
        {
            var Items = new EmployeeSchedule();
            Uri uri = new Uri($"https://iis.bsuir.by/api/v1/employees/schedule/{urlId}");
            HttpResponseMessage response = await _httpClient.GetAsync(uri);
            if (!response.IsSuccessStatusCode)
            {
                throw new StatusCodeException($"Error with exit code {response.StatusCode}!!!");
            }
            try
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<EmployeeSchedule>(responseContent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            if (Items == null)
            {
                throw new EmptyItemsConvertException("Empty url.");
            }
            return Items;
        }
        public async Task<List<AllGroupsList>> GetAllGroups()
        {
            var Items = new List<AllGroupsList>();
            Uri uri = new Uri("https://iis.bsuir.by/api/v1/student-groups");
            HttpResponseMessage response = await _httpClient.GetAsync(uri);
            if (!response.IsSuccessStatusCode)
            {
                throw new StatusCodeException($"Error with exit code {response.StatusCode}!!!");
            }
            try
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<List<AllGroupsList>>(responseContent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            if (Items == null)
            {
                throw new EmptyItemsConvertException("Empty url.");
            }
            return Items;
        }
        public async Task<List<AllEmployeesList>> GetAllEmployees()
        {
            var Items = new List<AllEmployeesList>();
            Uri uri = new Uri("https://iis.bsuir.by/api/v1/employees/all");
            HttpResponseMessage response = await _httpClient.GetAsync(uri);
            if (!response.IsSuccessStatusCode)
            {
                throw new StatusCodeException($"Error with exit code {response.StatusCode}!!!");
            }
            try
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<List<AllEmployeesList>>(responseContent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            if (Items == null)
            {
                throw new EmptyItemsConvertException("Empty url.");
            }
            return Items;
        }
        public async Task<List<AllFacultiesList>> GetAllFaculties()
        {
            var Items = new List<AllFacultiesList>();
            Uri uri = new Uri("https://iis.bsuir.by/api/v1/faculties");
            HttpResponseMessage response = await _httpClient.GetAsync(uri);
            if (!response.IsSuccessStatusCode)
            {
                throw new StatusCodeException($"Error with exit code {response.StatusCode}!!!");
            }
            try
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<List<AllFacultiesList>>(responseContent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            if (Items == null)
            {
                throw new EmptyItemsConvertException("Empty url.");
            }
            return Items;
        }
        public async Task<List<AllDepartmentsList>> GetAllDepartments()
        {
            var Items = new List<AllDepartmentsList>();
            Uri uri = new Uri("https://iis.bsuir.by/api/v1/departments");
            HttpResponseMessage response = await _httpClient.GetAsync(uri);
            if (!response.IsSuccessStatusCode)
            {
                throw new StatusCodeException($"Error with exit code {response.StatusCode}!!!");
            }
            try
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<List<AllDepartmentsList>>(responseContent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            if (Items == null)
            {
                throw new EmptyItemsConvertException("Empty url.");
            }
            return Items;
        }
        public async Task<List<AllSpecializationsList>> GetAllSpecializations()
        {
            var Items = new List<AllSpecializationsList>();
            Uri uri = new Uri("https://iis.bsuir.by/api/v1/specialities");
            HttpResponseMessage response = await _httpClient.GetAsync(uri);
            if (!response.IsSuccessStatusCode)
            {
                throw new StatusCodeException($"Error with exit code {response.StatusCode}!!!");
            }
            try
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<List<AllSpecializationsList>>(responseContent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            if (Items == null)
            {
                throw new EmptyItemsConvertException("Empty url.");
            }
            return Items;
        }
        public async Task<List<AllCurEmployeesAnnouncements>> GetCurEmployeesAnnouncements(string urlId)
        {
            var Items = new List<AllCurEmployeesAnnouncements>();
            Uri uri = new Uri($"https://iis.bsuir.by/api/v1/specialities?url-id={urlId}");
            HttpResponseMessage response = await _httpClient.GetAsync(uri);
            if (!response.IsSuccessStatusCode)
            {
                throw new StatusCodeException($"Error with exit code {response.StatusCode}!!!");
            }
            try
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<List<AllCurEmployeesAnnouncements>>(responseContent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            if (Items == null)
            {
                throw new EmptyItemsConvertException("Empty url.");
            }
            return Items;
        }
        public async Task<List<AllRelevantDepartmentAnnouncements>> GetRelevantDepartmentAnnouncements(int id)
        {
            var Items = new List<AllRelevantDepartmentAnnouncements>();
            Uri uri = new Uri($"https://iis.bsuir.by/api/v1/announcements/departments?id={id}");
            HttpResponseMessage response = await _httpClient.GetAsync(uri);
            if (!response.IsSuccessStatusCode)
            {
                throw new StatusCodeException($"Error with exit code {response.StatusCode}!!!");
            }
            try
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<List<AllRelevantDepartmentAnnouncements>>(responseContent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            if (Items == null)
            {
                throw new EmptyItemsConvertException("Empty url.");
            }
            return Items;
        }
        public async Task<List<AllAudiencesList>> GetAllAudiences()
        {
            var Items = new List<AllAudiencesList>();
            Uri uri = new Uri("https://iis.bsuir.by/api/v1/auditories");
            HttpResponseMessage response = await _httpClient.GetAsync(uri);
            if (!response.IsSuccessStatusCode)
            {
                throw new StatusCodeException($"Error with exit code {response.StatusCode}!!!");
            }
            try
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<List<AllAudiencesList>>(responseContent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            if (Items == null)
            {
                throw new EmptyItemsConvertException("Empty url.");
            }
            return Items;
        }
        public async Task<LastScheduleUpdate> GetLastScheduleUpdateDate(UpdateType updateType, string searchParameter)
        {
            var Items = new LastScheduleUpdate();
            Uri uri = new Uri(
                updateType == UpdateType.Employee 
                    ? $"https://iis.bsuir.by/api/v1/last-update-date/employee?url-id={searchParameter}" 
                    : $"https://iis.bsuir.by/api/v1/last-update-date/student-group?groupNumber={searchParameter}"
            );
            HttpResponseMessage response = await _httpClient.GetAsync(uri);
            if (!response.IsSuccessStatusCode)
            {
                throw new StatusCodeException($"Error with exit code {response.StatusCode}!!!");
            }
            try
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<LastScheduleUpdate>(responseContent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            if (Items == null)
            {
                throw new EmptyItemsConvertException("Empty url.");
            }
            return Items;
        }
        public async Task<int> GetCurrentWeek()
        {
            var Items = new int();
            Uri uri = new Uri("https://iis.bsuir.by/api/v1/schedule/current-week");
            HttpResponseMessage response = await _httpClient.GetAsync(uri);
            if (!response.IsSuccessStatusCode)
            {
                throw new StatusCodeException($"Error with exit code {response.StatusCode}!!!");
            }
            string responseContent = await response.Content.ReadAsStringAsync();
            Items = JsonConvert.DeserializeObject<int>(responseContent);
            if (Items == 0)
            {
                throw new EmptyItemsConvertException("Empty url.");
            }
            return Items;
        }
    }
}