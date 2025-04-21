using Acadmy_Reletional_EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acadmy_Reletional_EF.Data.Configuration
{
    ///
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {

            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id)
                .ValueGeneratedNever();


            builder.Property(i => i.name)
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();


            builder.ToTable("Students");

            builder.HasData(LoadStudents());

        }
        private static List<Student> LoadStudents()
        {
            return new List<Student>
    {
        new Student
        {
            Id = 1,
            name = "Alice"
        },
        new Student
        {
            Id = 2,
            name = "Bob"
        },
        new Student
        {
            Id = 3,
            name = "Charlie"
        }
    };
        }


    }

}



