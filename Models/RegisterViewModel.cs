using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class RegisterViewModel
    {
        public string name { get; set; }
        public string email { get; set; }
        public string Password { get; set; }

        [Compare("Password", ErrorMessage ="Parola Yanlış...")]
        public string Repassword { get; set; }

    }
}