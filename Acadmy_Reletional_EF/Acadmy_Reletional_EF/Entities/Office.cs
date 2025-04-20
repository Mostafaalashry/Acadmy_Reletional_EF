using System;
namespace Acadmy_Reletional_EF.Entities
{
	public class Office
	{
        public int Id { get; set; }

        public string? officeName { get; set; }

        public Instructor? Instructor { get; set; }

	}
}

