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
    
    public class CustomerController : Controller
    {
       private CustomerContext _context;
     
       public CustomerController(CustomerContext context){
           _context = context;

       }
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
           var customs = _context.Customers.AsQueryable();

           return customs;
        }
  
       [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _context.Customers.First(x => x.Id == id);
            _context.Customers.Remove(item);
            _context.SaveChanges();
         
        }
        [HttpPost]
        public Customer Post([FromBody]Customer value)
        {
             _context.Customers.Add(value);
             _context.SaveChanges();
             return value;
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Customer value)
        {
            var curStud = _context.Customers.FirstOrDefault(x => x.Id == id);
            curStud.Name = value.Name;
            curStud.Surname = value.Surname;
            curStud.PassportNumber = value.PassportNumber;
            curStud.DateOfFlight = value.DateOfFlight;
            _context.SaveChanges();
            
        }

    }
}