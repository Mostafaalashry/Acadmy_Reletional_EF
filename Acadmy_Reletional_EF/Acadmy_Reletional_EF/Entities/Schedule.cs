namespace Acadmy_Reletional_EF.Entities
{
    public class Schedule
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public bool SUN { get; set; }
        public bool MON { get; set; }
        public bool TUS { get; set; }
        public bool WED { get; set; }
        public bool THU { get; set; }
        public bool FRI { get; set; }
        public bool SAT { get; set; }
        public ICollection<Section> sections { get; set; } = new List<Section>();
        public ICollection<SectionSchedule> sectionSchedules { get; set; } = new List<SectionSchedule>();
    }

}
