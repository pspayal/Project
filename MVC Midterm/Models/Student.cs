          
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Midterm.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [Display]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required]
        public int CourseID { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        
        public DateTime CourseEnrolledDate { get; set; }
        
        [Required]
        public int CourseStatus { get; set; }

        [Required]
        public string Grade { get; set; }


    }
}