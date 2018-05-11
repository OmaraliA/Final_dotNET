using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final
{
    public class Product
    {
        [Key]
        public int ID{get;set;}
        public int CategoryId{get;set;}
        public int PlaceNumber{get;set;}
        public int  Price{get;set;}
    }

}