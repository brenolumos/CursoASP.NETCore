using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData
            (
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Kane Miller",
                    Age = 35,
                    Position = "Administrator",
                    CompanyId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Jana McLeaf",
                    Age = 30,
                    Position = "Software developer",
                    CompanyId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Bruno Lemos",
                    Age = 24,
                    Position = "Software developer",
                    CompanyId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
                }
            );
        }
    }
}
