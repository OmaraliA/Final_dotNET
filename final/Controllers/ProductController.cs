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
    
    public class ProductController : Controller
    {
       private ProductContext _context;
     
       public ProductController(ProductContext context){
           _context = context;

       }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
           var customs = _context.Products.AsQueryable();

           return customs;
        }
  
       [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _context.Products.First(x => x.ID == id);
            _context.Products.Remove(item);
            _context.SaveChanges();
         
        }
        [HttpPost]
        public Product Post([FromBody]Product value)
        {
             _context.Products.Add(value);
             _context.SaveChanges();
             return value;
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Product value)
        {
            var curStud = _context.Products.FirstOrDefault(x => x.ID == id);
            curStud.CategoryId = value.CategoryId;
            curStud.PlaceNumber = value.PlaceNumber;
            curStud.Price = value.Price;

            _context.SaveChanges();
        }

    }
}