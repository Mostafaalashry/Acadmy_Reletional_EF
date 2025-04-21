namespace Acadmy_Reletional_EF.Entities
{
    public class Course
    {

        public int Id { get; set; }

        public string courseName { get; set; }

        public decimal price { get; set; }

        public ICollection<Section> sections { get; set; } = new List<Section>();
     
    }

}

