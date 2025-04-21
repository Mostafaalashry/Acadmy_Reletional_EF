using Acadmy_Reletional_EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acadmy_Reletional_EF.Data.Configuration
{
    //
    public class SectionSchduleConfiguration : IEntityTypeConfiguration<SectionSchedule>
    {
        public void Configure(EntityTypeBuilder<SectionSchedule> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id)
                .ValueGeneratedNever();


            builder.Property(i => i.StartTime)
                .HasColumnType("time");


            builder.Property(i => i.EndtTime)
                .HasColumnType("time");


            builder.ToTable("SectionSchedules");

            builder.HasData(LoadSectionSchedule());

        }
        private static List<SectionSchedule> LoadSectionSchedule()
        {
            return new List<SectionSchedule>
    {
        new SectionSchedule
        {
            Id = 1,
            StartTime = TimeSpan.Parse("10:00:00"),
            EndtTime = TimeSpan.Parse("12:00:00"),       
            Schedule = 1
        },
        new SectionSchedule
        {

            Id = 2,
            StartTime = TimeSpan.Parse("12:00:00"),
            EndtTime = TimeSpan.Parse("01:00:00"),
            Schedule = 2
        },
        new SectionSchedule
        {

            Id = 3,
            StartTime = TimeSpan.Parse("05:00:00"),
            EndtTime = TimeSpan.Parse("07:00:00"),
            Schedule = 3
        }
    };
        }

    }
}



