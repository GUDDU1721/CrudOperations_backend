﻿using Microsoft.EntityFrameworkCore;

namespace CrudOperations_backend.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext>options) : base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set;}
    }
}
