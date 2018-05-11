using System;
using System.Collections.Generic;
using System.Linq;

namespace final.Models
{
     public interface IProjectsRepository2//dbinjection
   {
     IEnumerable<Product> GetAll();
    
   } 
    public class ProductRepository:IProjectsRepository2
    {
        private ProductContext _context;
        
        public ProductRepository( ProductContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll()
        {
           var cust = _context.Products.AsQueryable();
           return cust;
        }
        public void Delete(int id){
            Product c = _context.Products.FirstOrDefault(x=>x.ID == id);
            _context.Remove(c);       
        }
    }
   
}