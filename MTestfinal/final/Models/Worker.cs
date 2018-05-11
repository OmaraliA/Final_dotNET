using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace endterm
{
    public class Worker
    {

        [Key]
        public int Id{get;set;}
        public string Name{get;set;}
        public string Position{get;set;}
        public int IIN {get;set;}

        public string Dayofweek {get;set;}
        public DateTime Hours {get;set;}

        public string RDayofweek {get;set;}
        public DateTime RHours {get;set;}
    }
}