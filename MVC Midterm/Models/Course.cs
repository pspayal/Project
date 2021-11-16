using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Midterm.Models
{
    public class Course
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
        
        public string Discription { get; set; }

        public string TutorName {get; set;}

        [Required]
        public int CourseRating { get; set; }



    }
}