using System;
using System.Collections.Generic;
using System.Linq;

namespace final.Models
{
     public interface IProjectsRepository3//dbinjection
   {
     IEnumerable<Master> GetAll();
    
   } 
    public class MasterRepository:IProjectsRepository3
    {
        private MasterContext _context;
        
        public MasterRepository( MasterContext context)
        {
            _context = context;
        }

        public IEnumerable<Master> GetAll()
        {
           var cust = _context.Masters.AsQueryable();
           return cust;
        }
        public void Delete(int id){
            Master c = _context.Masters.FirstOrDefault(x=>x.Id == id);
            _context.Remove(c);       
        }
    }
   
}