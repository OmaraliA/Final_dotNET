using System;
using System.Collections.Generic;
using System.Linq;

namespace final.Models
{
     public interface IProjectsRepository5//dbinjection
   {
     IEnumerable<Report> GetAll();
    
   } 
    public class ReportRepository:IProjectsRepository5
    {
        private ReportContext _context;
        
        public ReportRepository( ReportContext context)
        {
            _context = context;
        }

        public IEnumerable<Report> GetAll()
        {
           var cust = _context.Reports.AsQueryable();
           return cust;
        }
        public void Delete(int id){
            Report c = _context.Reports.FirstOrDefault(x=>x.CategoryId == id);
            _context.Remove(c);       
        }
    }
   
}