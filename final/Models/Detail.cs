using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final
{
    public class Detail
    {
        [Key]
        public int Id{get;set;}
        public int CategoryId{get;set;}
        public int Place{get;set;}
        public DateTime DateOfSale{get;set;}
        public DateTime DateFlight{get;set;}

        public int Price{get;set;}

    }
}