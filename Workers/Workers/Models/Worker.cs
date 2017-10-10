using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Workers.Models
{
    public class Worker : Entity
    {
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Age is required")]
        [Range(1,130,ErrorMessage ="Age uncorrect")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Salary is required")]
        [Range(1,1000000000000000,ErrorMessage ="Salary uncorrect")]
        public float Salary { get; set; }
        
    }
}