namespace IISchedule.Models.AllRelevantDepartmentAnnouncements
{
    internal class AllRelevantDepartmentAnnouncements
    {
        public int id { get; set; }
        public string? employee { get; set; }
        public string? content { get; set; }
        public string? date { get; set; }
        public List<string>? employeeDepartments { get; set; }
        public List<StudentGroups>? studentGroups { get; set; }
    }
}
