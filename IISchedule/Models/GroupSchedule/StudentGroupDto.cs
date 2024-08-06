namespace IISchedule.Models.GroupSchedule
{
    class StudentGroupDto
    {
        public string? name { get; set; }
        public int facultyId { get; set; }
        public string? facultyAbbrev { get; set; }
        public int specialityDepartmentEducationFormId { get; set; }
        public string? specialityName { get; set; }
        public string? specialityAbbrev { get; set; }
        public int course { get; set; }
        public int id { get; set; }
        public string? calendarId { get; set; }
        public int educationDegree { get; set; }
    }
}
