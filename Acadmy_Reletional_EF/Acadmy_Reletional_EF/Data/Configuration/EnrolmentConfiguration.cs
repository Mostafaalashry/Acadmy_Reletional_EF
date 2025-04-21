using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Acadmy_Reletional_EF.Entities;

namespace Acadmy_Reletional_EF.Data.Configuration
{
    public class EnrolmentConfiguration : IEntityTypeConfiguration<Enrolment>
    {
        public void Configure(EntityTypeBuilder<Enrolment> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id)
                .ValueGeneratedNever();



            builder.ToTable("Enrolments");

            builder.HasData(LoadEnrolments());

        }
        private static List<Enrolment> LoadEnrolments()
        {
            return new List<Enrolment>
    {
        new Enrolment
        {
            Id = 1,
            SectionId = 1,
            StudentId = 1
        },
        new Enrolment
        {
            Id = 2,
            SectionId = 2,
            StudentId = 2
        },
        new Enrolment
        {
            Id = 3,
            SectionId = 3,
            StudentId = 3
        },
       
    };
        }


    }
}



