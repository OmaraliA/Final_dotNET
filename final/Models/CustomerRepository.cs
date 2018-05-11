using System;
using System.Collections.Generic;
using System.Linq;

namespace final.Models
{
     public interface IProjectsRepository//dbinjection
   {
     IEnumerable<Customer> GetAll();
    
   } 
    public class CustomerRepository:IProjectsRepository
    {
        private CustomerContext _context;
        
        public CustomerRepository( CustomerContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetAll()
        {
           var cust = _context.Customers.AsQueryable();
           return cust;
        }
        public void Delete(int id){
            Customer c = _context.Customers.FirstOrDefault(x=>x.Id == id);
            _context.Remove(c);       
        }
    }
   
}