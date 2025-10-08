using IKIEA.DAL.Models.Employee;
using IKIEA.DAL.Models.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKIEA.DAL.Configuration
{
    public class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Employee> builder)
        {
            builder.Property(p=>p.Name).HasColumnType("varchar(50)");
            builder.Property(p => p.Address).HasColumnType("varchar(150)");
            builder.Property(p => p.Salary).HasColumnType("decimal(10,3)");
            builder.Property(p => p.Gender).HasConversion(egender => egender.ToString(),gender=>(Gender)Enum.Parse(typeof(Gender),gender));
            builder.Property(p => p.EmployeeType).HasConversion(emptype => emptype.ToString(), temptype => (EmployeeType)Enum.Parse(typeof(EmployeeType), temptype));


        }
    }
}
