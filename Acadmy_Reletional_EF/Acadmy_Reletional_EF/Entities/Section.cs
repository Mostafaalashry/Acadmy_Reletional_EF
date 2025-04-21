namespace Acadmy_Reletional_EF.Entities
{
    public class Section
    {
        public int Id { get; set; }

        public string sectionName { get; set; }

        public int CourseeId { get; set; }

        public Course course { get; set; } 

        public int? InstructorId { get; set; }

        public Instructor? instructor { get; set; }

        public ICollection<Schedule> Schudules { get; set; } = new List<Schedule>();

        public ICollection<SectionSchedule> SectionSchedules { get; set; } = new List<SectionSchedule>();


    }

}

