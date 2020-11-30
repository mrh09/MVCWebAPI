using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class EmployeeModel
    {

        public int EmployeeId { get; set; }

        [Required(ErrorMessage ="This Field is required!!")]
        public string Name { get; set; }
        public string Division { get; set; }
    }
}