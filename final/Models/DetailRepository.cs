using System;
using System.Collections.Generic;
using System.Linq;

namespace final.Models
{
     public interface IProjectsRepository4//dbinjection
   {
     IEnumerable<Detail> GetAll();
    
   } 
    public class DetailRepository:IProjectsRepository4
    {
        private DetailContext _context;
        
        public DetailRepository( DetailContext context)
        {
            _context = context;
        }

        public IEnumerable<Detail> GetAll()
        {
           var cust = _context.Details.AsQueryable();
           return cust;
        }
        public void Delete(int id){
            Detail c = _context.Details.FirstOrDefault(x=>x.Id == id);
            _context.Remove(c);       
        }
    }
   
}