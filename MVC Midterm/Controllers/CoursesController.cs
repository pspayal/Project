using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_Midterm.Models;
using MVC_Midterm.View_Models;

namespace MVC_Midterm.Controllers
{
    public class CoursesController : Controller
    {

        private MVC_MidtermContext db = new MVC_MidtermContext();

        // GET: Courses
        public ActionResult Index()
        {
            var courses = db.Courses.ToList();

            return View(courses);
        }
        public ActionResult Create()
        {
            //var Courses = db.Courses.ToList();
            var CourseViewModel = new CourseViewModel()
                ;
              return View(CourseViewModel.Course);
        }

        // POST: save Student
        [HttpPost]
        public ActionResult Create(Course course)
        {
            //student.CourseEnrolledDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                db.Courses.Add(course);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(course);
        }

        // Nav to edit/view student
        public ActionResult Edit(int? ID)
        {
            if (ID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Courses.Find(ID);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // Post: Edit student
        [HttpPost]
        public ActionResult Edit(Course course)
        {
            //student.CourseEnrolledDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                db.Entry(course).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(course);
        }

        // Navigate to Delete student
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // Post: Delete student
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            Course course = db.Courses.Find(id);
            if (course != null)
            {
                db.Courses.Remove(course);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }

}
