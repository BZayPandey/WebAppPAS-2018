using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.ViewModel
{
    public class EmployeeViewModel

    {
        public int EmployeeID { get; set; }
        [Required (ErrorMessage="Employee Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Employee Position is required")]
        public string Position { get; set; }
        public string Office { get; set; }
        public int? Salary { get; set; }
    }
}