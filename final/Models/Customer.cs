using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final
{
    public class Customer
    {

        [Key]
        public int Id{get;set;}
        public string Name{get;set;}
        public string Surname{get;set;}
        public int PassportNumber {get;set;}
        public DateTime DateOfFlight {get;set;}

    }
}