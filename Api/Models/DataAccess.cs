using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext>options)
            :base(options)
        {
        }

        public class EmployeeDbContextFactory
        {
            public static EmployeeDbContext Create(string connectionString)
            {
                var optionsBuilder = new DbContextOptionsBuilder<EmployeeDbContext>();
                optionsBuilder.UseSqlServer(connectionString);
                var EmployeeDbContext = new EmployeeDbContext(optionsBuilder.Options);
                return EmployeeDbContext;
            }
        }
    }
}
