using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace final.Models 
{
    public class ProductContext: DbContext
    {
        public virtual DbSet<Product> Products {get; set;}


         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=Product;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }

    }
}