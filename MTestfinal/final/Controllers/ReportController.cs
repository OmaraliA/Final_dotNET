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
    
    public class ReportController : Controller
    {
       private ReportContext _context;
     
       public ReportController(ReportContext context){
           _context = context;

       }
        [HttpGet]
        public IEnumerable<Report> Get()
        {
           var customss = _context.Reports.AsQueryable();

           return customss;
        }
  
       [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _context.Reports.First(x => x.CategoryId == id);
            _context.Reports.Remove(item);
            _context.SaveChanges();
         
        }
        [HttpPost]
        public Report Post([FromBody]Report value)
        {
             _context.Reports.Add(value);
             _context.SaveChanges();
             return value;
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Report value)
        {
            var curStud = _context.Reports.FirstOrDefault(x => x.CategoryId == id);
            curStud.CategoryId = value.CategoryId;
          
           
    
            _context.SaveChanges();
        }


    }
}