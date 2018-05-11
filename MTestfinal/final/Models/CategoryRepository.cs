using System;
using System.Collections.Generic;
using System.Linq;

namespace final.Models
{
     public interface IProjectsRepository1//dbinjection
   {
     IEnumerable<Category> GetAll();
    
   } 
    public class CategoryRepository:IProjectsRepository1
    {
        private CategoryContext _context;
        
        public CategoryRepository( CategoryContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAll()
        {
           var cust = _context.Categorys.AsQueryable();
           return cust;
        }
        public void Delete(int id){
            Category c = _context.Categorys.FirstOrDefault(x=>x.CategoryID == id);
            _context.Remove(c);       
        }
    }
   
}