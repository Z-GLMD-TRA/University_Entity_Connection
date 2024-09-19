using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;


namespace Infrastructure.TableConfigs
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            //builder.HasKey(u => u.UserId);
            builder.HasOne(u => u.Address).WithOne().HasForeignKey<Student>(u => u.AddressId);
            builder.HasMany(s => s.Sessions).WithMany(s => s.Students);
            builder.HasOne(d=>d.Department).WithMany(d=>d.Students).HasForeignKey(d => d.DepartmentId);
        }
    }
}
