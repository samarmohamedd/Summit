using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Summit.Models
{
    public class Employee
    {
        [Key]
        public int Empid { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public string City { get; set; }

        public string Address { get; set; }
    }
}