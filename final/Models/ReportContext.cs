using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace final.Models 
{
    public class ReportContext: DbContext
    {
        public virtual DbSet<Report> Reports {get; set;}


         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=Report;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public ReportContext(DbContextOptions<ReportContext> options) : base(options)
        {
        }

    }
}