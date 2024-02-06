using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppP3pp2.Models;

namespace WebAppP3pp2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        static List<Student> studentsdata = new List<Student>()
        {
            new Student(){Id=1,Name="Syed",Class=4},
            new Student(){Id=2,Name="Sita",Class=2},
            new Student(){Id=3,Name="Shyam",Class=8},
            new Student(){Id=4,Name="Sony",Class=4},
            new Student(){Id=5,Name="Sama",Class=7},
            new Student(){Id=6,Name="Sana",Class=2},

        };
        public ActionResult Index()
        {
            return View(studentsdata);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Student());
        }
        [HttpPost]
        public ActionResult Create(Student stu)
        {
            if (ModelState.IsValid)
            {
                studentsdata.Add(stu);
                return RedirectToAction("Index");
            }
            return View(stu);
        }
    }
}