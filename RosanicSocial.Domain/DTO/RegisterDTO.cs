using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RosanicSocial.Domain.DTO {
    public class RegisterDTO {
        [Required(ErrorMessage = "Name can't be empty")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Last name can't be empty")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Username can't be empty")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Email can't be empty")]
        [EmailAddress(ErrorMessage = "Email should be in a proper format")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Password can't be empty")]
        [DataType(DataType.Password)] 
        public string Password { get; set; }
    }
}
