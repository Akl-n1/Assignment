using EntityFramework_01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_01.ConfigrationClasses
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Projects");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id)
                   .UseIdentityColumn(10, 10);

            builder.Property(p => p.Name)
                   .HasColumnType("varchar(50)")
                   .IsRequired()
                   .HasDefaultValue("OurProject");

            builder.Property(p => p.Cost)
                   .HasColumnType("money");

            builder.ToTable(t =>
            {
                t.HasCheckConstraint("CK_Project_Cost", "Cost BETWEEN 500000 AND 3500000");
            });
        }
    }
}
