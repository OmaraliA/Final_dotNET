using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace final.Models 
{
    public class CustomerContext: DbContext 
    {
        public virtual DbSet<Customer> Customers {get; set;}


         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=Customers;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }

    }
}