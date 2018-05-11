using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace final.Models 
{
    public class MasterContext: DbContext
    {
        public virtual DbSet<Master> Masters {get; set;}


         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=Master;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public MasterContext(DbContextOptions<MasterContext> options) : base(options)
        {
        }

    }
}