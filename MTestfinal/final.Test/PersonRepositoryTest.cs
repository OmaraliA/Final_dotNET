using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using final.Models;
using final.Controllers;

namespace final.Test
{
    [TestClass]
    public class PersonRepositoryTest
    {
        [TestMethod]
        public void CheckRepository()
        {
            var repository = new PersonRepositoryLocal();
            var manager = new CustomerManager(repository);
        
            var data = manager.Get() as List<Customer>;    
            Assert.IsNotNull(data);            
        }
        [TestMethod]
        public void Correct()
        {
             var repository = new PersonRepositoryLocal();
            DateTime date1 = new DateTime(2010, 8, 12);
             DateTime date2 = new DateTime(2011, 8, 18);
             Customer p = new Customer() {
                Id = 10, Name = "Aru", Surname = "Omarali",  PassportNumber = 477978,  DateOfFlight = date2
            };  
             var manager = new CustomerManager(repository);
       
             bool val = manager.Validate(p);   
            Assert.AreEqual(val, true);
             

        }
        [TestMethod]
        public void Incorrect()
        {
             var repository = new PersonRepositoryLocal();
             DateTime date1 = new DateTime(2010, 8, 12);
             DateTime date2 = new DateTime(2011, 8, 18);
             Customer p = new Customer() {
              Id = 1, Name = "Aru", Surname = "Omarali",  PassportNumber = -1555,  DateOfFlight = date1
            };  
             var manager = new CustomerManager(repository);
       
             bool val = manager.Validate(p);   
             Assert.AreEqual(val, false);
             
        }

    }
}
