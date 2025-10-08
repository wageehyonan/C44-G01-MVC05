using IKIEA.DAL.Models.Departments;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace IKIEA.DAL.Configuration
{
    public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(p => p.Id).UseIdentityColumn(10, 10);
            builder.Property(p => p.Name).HasColumnType("varchar(20)");
            builder.Property(p => p.Code).HasColumnType("varchar(20)");
        }
    }
}
