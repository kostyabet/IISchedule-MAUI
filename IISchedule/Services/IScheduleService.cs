using IISchedule.Models.GroupSchedule;

namespace IISchedule.Services
{
    internal interface IScheduleService
    {
        Task<GroupSchedule> GetGroupSchedule(string groupNumber);
    }
}
