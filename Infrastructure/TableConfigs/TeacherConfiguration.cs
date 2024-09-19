using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.TableConfigs
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
           // builder.HasKey(u=>u.UserId);
            builder.HasOne(u => u.Address).WithOne().HasForeignKey<Teacher>(u => u.AddressId);

            builder.HasOne(d => d.Department).WithMany(d => d.Teachers).HasForeignKey(d => d.DepartmentId);
            builder.HasMany(s => s.Sessions).WithOne(s => s.Teacher).HasForeignKey(s=>s.TeacherId);
        }
    }
}
