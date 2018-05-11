using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final
{
    public class Category
    {

        public int CategoryID{get;set;}
        public int FlightID{get;set;}
        public string PlainName{get;set;}
        public DateTime Flight{get;set;}
        public string Destination {get; set;}
        
    }

}