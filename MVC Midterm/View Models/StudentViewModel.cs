using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Midterm.Models;

namespace MVC_Midterm.View_Models
{
    public class StudentViewModel
    {
        public Student Student { get; set; }
        public IEnumerable<Course> Courses { get; set; }

    }
}