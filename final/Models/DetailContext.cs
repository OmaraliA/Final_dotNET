using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace final.Models 
{
    public class DetailContext: DbContext
    {
        public virtual DbSet<Detail> Details {get; set;}


         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=Detail;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public DetailContext(DbContextOptions<DetailContext> options) : base(options)
        {
        }

    }
}