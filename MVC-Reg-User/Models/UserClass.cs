using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Reg_User.Models
{
    public class UserClass
    {
        [Required(ErrorMessage="Enter username!")]
        [Display(Name="Enter username: ")]
        [StringLength(maximumLength:7,MinimumLength=3,ErrorMessage="Enter  Length Must Be Max 7 & Min is 3")]
        public string Uname { get; set; }


        [Required(ErrorMessage = "Please Enter The Email Address!")]
        [Display(Name = "Enter Email Id:")]
        public string Uemail { get; set; }
        
        

        [Required(ErrorMessage = "Pleaseenter password")]
        [Display(Name = "Enter password:")]
        [DataType(DataType.Password)]           
        public string Upwd { get; set; }

        [Required(ErrorMessage = "Please Select Gender")]
        [Display(Name = "Gender:")]
        public char Gender { get; set; }

        //[Required(ErrorMessage = "Upload Profile Image!")]
        //[Display(Name = "Profile Image:")]
        //public string Uimg { get; set; }
    }
}
