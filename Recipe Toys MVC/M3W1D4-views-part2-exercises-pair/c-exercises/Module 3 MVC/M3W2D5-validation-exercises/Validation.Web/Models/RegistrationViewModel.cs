using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Validation.Web.Models
{
    public class RegistrationViewModel
    {

        [Required]
        [MaxLength(20, ErrorMessage ="*")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage ="*")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="Please enter a valid email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Compare("Email")]
        public string ConfirmEmail { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or more")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "# of Tickets must be between 1-10")]
        [DataType(DataType.PhoneNumber)]
        public string NumOfTickets { get; set; }
    }
}