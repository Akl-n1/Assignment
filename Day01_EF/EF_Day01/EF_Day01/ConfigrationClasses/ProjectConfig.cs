using EF_Day01.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Day01.ConfigrationClasses
{
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Projects");
            builder.HasKey(x => x.Id);
            builder
                .Property(x => x.Id)
                .UseIdentityColumn(10, 10);
            builder
                .Property(x => x.Name)
                .HasColumnType("varchar(50)")
                .HasDefaultValue("OurProject")
                .IsRequired();
            builder
                .Property(p => p.Cost)
                .HasColumnType("money");

            builder.ToTable(t =>
            {
                t.HasCheckConstraint("CK_Project_Cost", "Cost BETWEEN 500000 AND 3500000");
            });
        }
    }
}
