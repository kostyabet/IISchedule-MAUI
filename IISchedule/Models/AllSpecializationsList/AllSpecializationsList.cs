using IISchedule.Models.AllSpecializationsList;

namespace IISchedule.Models.AllSpecializationsList
{
    class AllSpecializationsList
    {
        public int? id { get; set; }
        public string? name { get; set; }
        public string? abbrev { get; set; }
        public EducationForm? educationForm { get; set; }
        public int? facultyId { get; set; }
        public string? code { get; set; }
    }
}
