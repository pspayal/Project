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
    public class StudentController : Controller
    {
        private MVC_MidtermContext db = new MVC_MidtermContext();

        // GET: Students
        public ActionResult Index()
        {
            var _context = new MVC_MidtermContext();
                var Students = db.Students.ToList();
            return View(Students);
        }

        // Load create page
        public ActionResult Create()
        {
            var Coursesval = db.Courses.ToList();
            var StudentViewModel = new StudentViewModel()
            {
                Courses = Coursesval
            };            //{ 

            //var Student = new Student();
            //CouseList}

            //ViewData["Courses"] = db.Courses.ToList(); 
            return View(StudentViewModel);
        }

        // POST: save Student
        [HttpPost]
        public ActionResult Create(Student student)
        {
            student.CourseEnrolledDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // Nav to edit/view student
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // Post: Edit student
        [HttpPost]
        public ActionResult Edit(Student student)
        {
            student.CourseEnrolledDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // Navigate to Delete student
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // Post: Delete student
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            Student student = db.Students.Find(id);
            if (student != null)
            {
                db.Students.Remove(student);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}