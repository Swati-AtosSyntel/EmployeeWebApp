using EmployeeWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeWebApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index(int id)
        {
            //to pass any data from controller to view , use Viewbag
            //viewbag is a dynamic object introduced in .net framework 4.0
            //
            ViewBag.data = id;
            //ViewData is dictionary object and can be used to pass data from controller to view
            ViewData["ID"] = id;

            return View();
        }
        public ActionResult StudentDetails()
        {
            Student s = new Student() { sid = 1, sname = "Shivani" };
            ViewBag.std = s;
            ViewData["std"] = s;
            return View();
        }
    }
}