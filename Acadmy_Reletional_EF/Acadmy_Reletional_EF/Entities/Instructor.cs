using System;
namespace Acadmy_Reletional_EF.Entities
{
    public class Instructor
	{
		public int Id { get; set; }

		public string?	name { get; set; }

        public int? OfficeId { get; set; }

        public Office? office { get; set; }

        public ICollection<Section> sections { get; set; } = new List<Section>();

    }

}

