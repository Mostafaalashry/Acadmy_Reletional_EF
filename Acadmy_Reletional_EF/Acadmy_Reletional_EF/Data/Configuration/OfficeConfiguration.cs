using Acadmy_Reletional_EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acadmy_Reletional_EF.Data.Configuration
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id)
                .ValueGeneratedNever();



            builder.Property(i => i.officeName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();



            builder.ToTable("Offices");
            builder.HasData(LoadOffice());


        }
        private static List<Office> LoadOffice()
        {
            return new List<Office>
    {
        new Office
        {
            Id  = 1,
            officeName = "Main Building - Room 101"
        },
        new Office
        {
            Id  = 2,
            officeName = "Science Block - Room 202"
        },
        new Office
        {
            Id  = 3,
            officeName = "Library - Room 303"
        }
    };
        }

    }
}

