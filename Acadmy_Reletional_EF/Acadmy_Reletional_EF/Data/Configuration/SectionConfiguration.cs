using Acadmy_Reletional_EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acadmy_Reletional_EF.Data.Configuration
{
    // public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    public class SectionConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id)
                .ValueGeneratedNever();

            builder.HasOne(i => i.course)
                .WithMany(i => i.sections)
                .HasForeignKey(i => i.CourseeId)
                .IsRequired();

            builder.HasOne(i => i.instructor)
               .WithMany(i => i.sections)
               .HasForeignKey(i => i.InstructorId)
               .IsRequired(false);

            builder.Property(i => i.sectionName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();


            builder.ToTable("Sections");
            builder.HasData(LoadSection());



        }
        private static List<Section> LoadSection()
        {
            return new List<Section>
    {
        new Section
        {
            Id = 1,
            sectionName = "Math Section A",
            CourseeId = 1,        // assumes Course with Id = 1 exists
            InstructorId = 1      // assumes Instructor with Id = 1 exists
        },
        new Section
        {
            Id = 2,
            sectionName = "Physics Section B",
            CourseeId = 2,        // assumes Course with Id = 2 exists
            InstructorId = 2      // assumes Instructor with Id = 2 exists
        },
        new Section
        {
            Id = 3,
            sectionName = "Chemistry Section C",
            CourseeId = 3,        // assumes Course with Id = 3 exists
            InstructorId = 3   // optional, no assigned instructor
        }
    };
        }

    }
}



