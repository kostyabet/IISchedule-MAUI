using IISchedule.Models.AllAudiencesList;
using IISchedule.Models.AllCurEmployeesAnnouncements;
using IISchedule.Models.AllDepartmentsList;
using IISchedule.Models.AllEmployeesList;
using IISchedule.Models.AllFacultiesList;
using IISchedule.Models.AllGroupsList;
using IISchedule.Models.AllRelevantDepartmentAnnouncements;
using IISchedule.Models.AllSpecializationsList;
using IISchedule.Models.EmployeeSchedule;
using IISchedule.Models.GroupSchedule;
using IISchedule.Models.LastScheduleUpdate;

namespace IISchedule.Services
{
    internal interface IScheduleService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="groupNumber"></param>
        /// <returns></returns>
        Task<GroupSchedule> GetGroupSchedule(string groupNumber);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="urlId"></param>
        /// <returns></returns>
        Task<EmployeeSchedule> GetEmployeeSchedule(string urlId);
        Task<List<AllGroupsList>> GetAllGroups();
        Task<List<AllEmployeesList>> GetAllEmployees();
        Task<List<AllFacultiesList>> GetAllFaculties();
        Task<List<AllDepartmentsList>> GetAllDepartments();
        Task<List<AllSpecializationsList>> GetAllSpecializations();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="urlId"></param>
        /// <returns></returns>
        Task<List<AllCurEmployeesAnnouncements>> GetCurEmployeesAnnouncements(string urlId);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<AllRelevantDepartmentAnnouncements>> GetRelevantDepartmentAnnouncements(int id);
        Task<List<AllAudiencesList>> GetAllAudiences();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="updateType"></param>
        /// <param name="serchParameter"></param>
        /// <returns></returns>
        Task<LastScheduleUpdate> GetLastScheduleUpdateDate(UpdateType updateType, string searchParameter);
        Task<int> GetCurrentWeek();
    }
}
