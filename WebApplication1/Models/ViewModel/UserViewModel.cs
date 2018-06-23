using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.ViewModel
{
    public class UserViewModel
    {
        public int Userid { get; set; }
        [Required( ErrorMessage="Username required")]
        public string Username { get; set; }
        [Required (ErrorMessage="Password required")]
        public string Password { get; set; }
    }
}