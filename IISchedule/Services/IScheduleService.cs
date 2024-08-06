using IISchedule.Models.AllCurEmployeesAnnouncements;
using IISchedule.Models.AllDepartmentsList;
using IISchedule.Models.AllEmployeesList;
using IISchedule.Models.AllFacultiesList;
using IISchedule.Models.AllGroupsList;
using IISchedule.Models.AllSpecializationsList;
using IISchedule.Models.EmployeeSchedule;
using IISchedule.Models.GroupSchedule;

namespace IISchedule.Services
{
    internal interface IScheduleService
    {
        Task<GroupSchedule> GetGroupSchedule(string groupNumber);
        Task<EmployeeSchedule> GetEmployeeSchedule(string urlId);
        Task<List<AllGroupsList>> GetAllGroups();
        Task<List<AllEmployeesList>> GetAllEmployees();
        Task<List<AllFacultiesList>> GetAllFaculties();
        Task<List<AllDepartmentsList>> GetAllDepartments();
        Task<List<AllSpecializationsList>> GetAllSpecializations();
        Task<List<AllCurEmployeesAnnouncements>> GetCurEmployeesAnnouncements(string urlId);
    }
}
