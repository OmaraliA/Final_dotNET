using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final
{
    public class Master
    {

        [Key]
        public int Id{get;set;}
        public DateTime DateOfSale{get;set;}
        public string CustName{get;set;}
        public string CustSurname {get;set;}

        public int CustDocument {get;set;}
    
    }

}