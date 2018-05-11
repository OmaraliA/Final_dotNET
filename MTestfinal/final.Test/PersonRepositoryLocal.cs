using System.Collections.Generic;
using final.Models;
using System;

namespace final.Test
{
    public class PersonRepositoryLocal : IProjectsRepository
    {
        public IEnumerable<Customer> GetAll()
        {
            var result = new List<Customer>();
            DateTime date1 = new DateTime(2010, 8, 12);
             DateTime date2 = new DateTime(2011, 8, 18);
            result.Add(new Customer(){ Id = 1, Name = "Aru", Surname = "Omarali",  PassportNumber = 477978,  DateOfFlight = date1 });
            result.Add(new Customer(){ Id = 2, Name = "Nazym", Surname = "Turysbek",  PassportNumber = 7878, DateOfFlight = date1  });
            result.Add(new Customer(){ Id = 3, Name = "Saltanat", Surname = "Shapkhatova", PassportNumber = 7878,DateOfFlight = date2 });
            result.Add(new Customer(){ Id = 4, Name = "Ainur", Surname = "Abay",  PassportNumber =79878, DateOfFlight = date2});

            IEnumerable<Customer> pr = result;
            return pr;
        }
         public void Delete(int id){

         }
          public Customer Post(Customer value)
          {
             Customer p = new Customer();
             return p;
          }
           public void Put(int id, Customer value)
           {
           }

    }
}