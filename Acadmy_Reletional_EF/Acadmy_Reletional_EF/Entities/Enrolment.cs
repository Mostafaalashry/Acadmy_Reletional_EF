namespace Acadmy_Reletional_EF.Entities
{
    public class Enrolment
    {
        public int Id { get; set; }

        public int SectionId { get; set; }
        public int StudentId { get; set; }

        public Section section { get; set; } = null!;
        public Student student { get; set; } = null!;

    }

}

