using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Stack.DTOs.Requests
{
    // Login Model . 
    public class LoginModel
    {
        [Required]
        public string ERP_USER { get; set; }

        [Required]
        public string Password { get; set; }
        public DateTime Date { get; set; }
    }
}
