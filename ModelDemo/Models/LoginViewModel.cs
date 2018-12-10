using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ModelDemo.Models
{
    public class LoginViewModel
    {
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Too long name!!!")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        [Display(Name = "Remember my login")]
        public bool Remember { get; set; }
    }
}