namespace IISchedule.Models.GroupSchedule
{
    class GroupSchedule
    {
        public string? employeeDto { get; set; }
        public StudentGroupDto? studentGroupDto { get; set; }
        public Schedules? schedules { get; set; }
        public Schedule? examSchudule { get; set; }
        public string? startDate { get; set; }
        public string? endDate { get; set; }
        public string? startExamsDate { get; set; }
        public string? endExamsDate { get; set; }
    }
}