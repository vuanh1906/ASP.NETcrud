using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CourseMan.Models
{
    public class Student
    {   
        [StringLength(10)]
        //[RegularExpression("^[0 - 9L] */{10/}$", ErrorMessage = "Are u FITer ??? ")]
        [Remote(controller: "Students", action: "VerifyID")]
        public string StudentId { get; set; }
        [Required]
        public string FirstName { get; set;}
        [Required]
        public string LastMidName { get; set;}
    }
}
