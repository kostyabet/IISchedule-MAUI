using IISchedule.Models.AllGroupsList;
using IISchedule.Models.EmployeeSchedule;
using IISchedule.Models.GroupSchedule;

namespace IISchedule.Services
{
    internal interface IScheduleService
    {
        Task<GroupSchedule> GetGroupSchedule(string groupNumber);
        Task<EmployeeSchedule> GetEmployeeSchedule(string urlId);
        Task<IList<AllGroupsList>> GetAllGroups();
    }
}
