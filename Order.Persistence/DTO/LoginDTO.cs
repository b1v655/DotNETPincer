using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Order.Persistence.DTO
{
    public class LoginDTO
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
