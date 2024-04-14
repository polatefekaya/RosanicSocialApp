using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RosanicSocial.Domain.DTO {
    public class LoginDTO {
        [Required(ErrorMessage = "Username is required to login")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required to login")]
        public string Password { get; set; }
    }
}
