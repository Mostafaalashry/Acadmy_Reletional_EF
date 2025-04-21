using Acadmy_Reletional_EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acadmy_Reletional_EF.Data.Configuration
{
    ///
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id)
                .ValueGeneratedNever();

          
            builder.Property(i => i.Title)
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired(false);


            builder.ToTable("Schedules");

            builder.HasData(Loadschedules());

        }
        private static List<Schedule> Loadschedules()
        {
            return new List<Schedule>
    {
        new Schedule
        {
            Id = 1,
            Title = "Morning Schedule",
            SUN = true,
            MON = true,
            TUS = true,
            WED = false,
            THU = false,
            FRI = true,
            SAT = false
        },
        new Schedule
        {
            Id = 2,
            Title = "Evening Schedule",
            SUN = false,
            MON = true,
            TUS = false,
            WED = true,
            THU = true,
            FRI = false,
            SAT = true
        },
        new Schedule
        {
            Id = 3,
            Title = "Weekend Schedule",
            SUN = true,
            MON = false,
            TUS = false,
            WED = false,
            THU = false,
            FRI = false,
            SAT = true
        }
    };
        }



    }


}



