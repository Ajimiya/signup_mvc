using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using Microsoft.OData.Edm;

namespace MVC_reg_Application.Models
{
    public class UserClass
    {
        [Required (ErrorMessage ="Enter username !")]
        [Display (Name ="Enter Firstname  : ")]
        [StringLength(maximumLength:7,MinimumLength =3,ErrorMessage ="Username Length Must be max 7 & Min 3")]
        public string Fname { get; set; }

        [Required(ErrorMessage ="Please Enter the mail address ! ")]
        [Display (Name ="Enter Lastname : ")]
        public string Lname { get; set; }
        public Date Dob { get; set; }
        [Required(ErrorMessage ="Please Enter the gender! ")]
        [Display(Name = "Enter gender  : ")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please Enter the phone number! ")]
        [Display(Name = "Enter Phone number   : ")]
        public string Phonenumber { get; set; }
        [Required(ErrorMessage ="Please Enter the mail! ")]
        [Display(Name = "Enter Email Id  : ")]
        public string  Email { get; set; }
        [Required(ErrorMessage = "Please Enter the Address! ")]
        [Display(Name = "Enter the address : ")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please select state! ")]
        [Display(Name = "Select state ")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please select city! ")]
        [Display(Name = "Select city : ")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please Enter username! ")]
        [Display(Name = "Enter username  : ")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please Enter password! ")]
        [Display(Name = "Enter Password  : ")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please Enter Repassword! ")]
        [Display(Name = "Enter Repassword  : ")]
        public string Cpassword { get; set; }
        [Required(ErrorMessage = "upload profile image! ")]
        [Display(Name = "profile image  : ")]
        public string Uimg { get; set; }
    }
}