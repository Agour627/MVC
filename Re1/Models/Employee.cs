using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Re1.Models
{
    public class Employee
    {
        [Key]
        public int SSN { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}