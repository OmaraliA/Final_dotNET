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
    
    public class MasterController : Controller
    {
       private MasterContext _context;
     
       public MasterController(MasterContext context){
           _context = context;

       }
        [HttpGet]
        public IEnumerable<Master> Get()
        {
           var customs = _context.Masters.AsQueryable();

           return customs;
        }
  
       [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _context.Masters.First(x => x.Id == id);
            _context.Masters.Remove(item);
            _context.SaveChanges();
         
        }
        [HttpPost]
        public Master Post([FromBody]Master value)
        {
             _context.Masters.Add(value);
             _context.SaveChanges();
             return value;
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Master value)
        {
            var curStud = _context.Masters.FirstOrDefault(x => x.Id == id);
            curStud.DateOfSale = value.DateOfSale;
            curStud.CustName = value.CustName;
            curStud.CustSurname = value.CustSurname;
            curStud.CustDocument = value.CustDocument;
            _context.SaveChanges();
        }

    }
}