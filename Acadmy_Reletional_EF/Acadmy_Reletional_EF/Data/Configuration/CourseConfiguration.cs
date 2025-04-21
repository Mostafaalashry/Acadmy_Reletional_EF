using Acadmy_Reletional_EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acadmy_Reletional_EF.Data.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id)
                .ValueGeneratedNever();


            builder.Property(i => i.courseName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(i => i.price)
                .HasColumnType("decimal(15,2)");
                  

            builder.ToTable("Courses");
            builder.HasData(LoadCourses());


        }
        private static List<Course> LoadCourses()
        {
            return new List<Course>
    {
        new Course
        {
            Id = 1,
            courseName = "Mathematics",
            price = 500
        },
        new Course
        {
            Id = 2,
            courseName = "Physics",
            price = 600
        },
        new Course
        {
            Id = 3,
            courseName = "Chemistry",
            price = 550
        }
    };
        }


    }
}

