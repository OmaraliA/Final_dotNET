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
    
    public class DetailController : Controller
    {
       private DetailContext _context;
     
       public DetailController(DetailContext context){
           _context = context;

       }
        [HttpGet]
        public IEnumerable<Detail> Get()
        {
           var customs = _context.Details.AsQueryable();

           return customs;
        }
  
       [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _context.Details.First(x => x.Id == id);
            _context.Details.Remove(item);
            _context.SaveChanges();
         
        }
        [HttpPost]
        public Detail Post([FromBody]Detail value)
        {
             _context.Details.Add(value);
             _context.SaveChanges();
             return value;
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Detail value)
        {
            var curStud = _context.Details.FirstOrDefault(x => x.Id == id);
            curStud.CategoryId = value.CategoryId;
            curStud.Place = value.Place;
            curStud.DateOfSale = value.DateOfSale;
            curStud.DateFlight = value.DateFlight;
            curStud.Price = value.Price;
            _context.SaveChanges();
        }

    }
}