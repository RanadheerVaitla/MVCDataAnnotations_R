using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCDataAnnotations.Models
{
    public class User
    {
        [DataType(DataType.Text)]
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "Name can't be empty")]
        [RegularExpression(@"[A-Za-z\s]{4,}", ErrorMessage = "Name can have Alphabets and spaces only")]
        public string Name { get; set; }


        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password can't be empty")]
        [RegularExpression(@"(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$_-])(?=\S+$).{8,16}", ErrorMessage = "Password Format: <br />-Minimum 1 upper case & lower case alphabet.<br />-Minimum 1 numeric.<br />-Minimum 1, any of these Special characters: -, _, @, #, $.<br />-No spaces.<br />-Should be ranging between 8 - 16 chars.")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirm Password can't be empty")]
        [Compare("Password", ErrorMessage = "Password and confirm password must be same")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Date of birth can't be empty")]
        [System.Web.Mvc.Remote("IsValidDate", "User", ErrorMessage = "You must attain 18 years of age to register.")]
        public string DOB { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"[6-9]\d{9}")]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
    }
}