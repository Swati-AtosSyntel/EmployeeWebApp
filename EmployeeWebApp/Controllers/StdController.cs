using EmployeeWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeWebApp.Controllers
{
    public class StdController : Controller
    {
        // GET: Std
        public ActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){sid=1,sname="Swati"},
                new Student(){sid=2,sname="Nishant"},
                new Student(){sid=3,sname="Bhushan"}
            };
            return View(students);
        }

        // GET: Std/Details/5
        public ActionResult Details(int? id)
        {
            return View();
        }

        // GET: Std/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Std/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Std/Edit/5
        public ActionResult Edit(int? id)
        {
            return View();
        }

        // POST: Std/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Std/Delete/5
        public ActionResult Delete(int? id)
        {
            return View();
        }

        // POST: Std/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
