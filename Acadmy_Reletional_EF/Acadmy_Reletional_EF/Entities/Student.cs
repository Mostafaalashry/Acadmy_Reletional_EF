namespace Acadmy_Reletional_EF.Entities
{
    public class Student
    {
        public int Id { get; set; }

        public string name { get; set; }

        public ICollection<Section> Sections { get; set; } = new List<Section>();

    }

}

