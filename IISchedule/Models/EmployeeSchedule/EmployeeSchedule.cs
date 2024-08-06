using IISchedule.Models.EmployeeSchedule;

namespace IISchedule.Models.EmployeeSchedule
{
    internal class EmployeeSchedule
    {
        public EmployeeDto employeeDto { get; set; }
        public string studentGroupDto { get; set; }
        public Schedules schedules { get; set; }
        public Schedule exams { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string startExamsDate { get; set; }
        public string endExamsDate { get; set; }
    }
}
