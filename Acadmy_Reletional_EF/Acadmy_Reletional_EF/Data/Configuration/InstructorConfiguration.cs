using System;
using Acadmy_Reletional_EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acadmy_Reletional_EF.Data.Configuration
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id)
                .ValueGeneratedNever();

            builder.HasOne(i => i.office)
                .WithOne(i => i.Instructor)
                .HasForeignKey<Instructor>(i => i.OfficeId)
                .IsRequired(false);
        

            builder.Property(i => i.name)
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();


            builder.ToTable("Instructors");

            builder.HasData(LoadInstructor());

        }
        private static List<Instructor> LoadInstructor()
        {
            return new List<Instructor>
    {
        new Instructor
        {
            Id = 1,
            name = "Dr. Sarah Ahmed",
            OfficeId = 1
        },
        new Instructor
        {
            Id = 2,
            name = "Prof. Ali Hassan",
            OfficeId = 2
        },
        new Instructor
        {
            Id = 3,
            name = "Ms. Mariam Nabil",
            OfficeId = 3 
        }
    };
        }

    }
   

}



