using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace final.Controllers
{

    [Route("api/[controller]")]
    
    public class CategoryController : Controller
    {
       private CategoryContext _context;
     
       public CategoryController(CategoryContext context){
           _context = context;

       }
        [HttpGet]
        public IEnumerable<Category> Get()
        {
           var customs = _context.Categorys.AsQueryable();

           return customs;
        }
  
       [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _context.Categorys.First(x => x.CategoryID == id);
            _context.Categorys.Remove(item);
            _context.SaveChanges();
         
        }
        [HttpPost]
        public Category Post([FromBody]Category value)
        {
             _context.Categorys.Add(value);
             _context.SaveChanges();
             return value;
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Category value)
        {
            var curStud = _context.Categorys.FirstOrDefault(x => x.CategoryID == id);
            curStud.CategoryID = value.CategoryID;
            curStud.FlightID = value.FlightID;
            curStud.PlainName = value.PlainName;
            curStud.Flight = value.Flight;
            curStud.Destination = value.Destination;
            _context.SaveChanges();
        }

    }
}