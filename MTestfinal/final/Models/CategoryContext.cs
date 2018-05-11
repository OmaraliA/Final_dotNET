using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace final.Models 
{
    public class CategoryContext: DbContext
    {
        public virtual DbSet<Category> Categorys {get; set;}


         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=Category;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public CategoryContext(DbContextOptions<CategoryContext> options) : base(options)
        {
        }

    }
}