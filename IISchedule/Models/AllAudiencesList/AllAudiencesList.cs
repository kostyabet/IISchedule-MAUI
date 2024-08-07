namespace IISchedule.Models.AllAudiencesList
{
    class AllAudiencesList
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? note { get; set; }
        public string? capacity { get; set; }
        public AuditoryType auditoryType { get; set; }
        public BuildingNumber? buildingNumber { get; set; }
        public Department? department { get; set; }
    }
}
