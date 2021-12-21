using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstAp.Models
{
    public class Student { 
        //[key]
        //[Required]
        //[DisplayName="Student Id"]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

}