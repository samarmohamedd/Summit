using Summit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Summit.Controllers
{
    public class EmployeeController : Controller
    {
        EmpDataContext Db = new EmpDataContext();

        // GET: Employee
        public ActionResult Index()
        {
            return View(Db.Employees.ToList());
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            int empId = Convert.ToInt32(id);
            var emp = Db.Employees.Find(id);
            return View(emp);
        }

        // GET: Employee/Create
        public ActionResult Create(Employee objEmp)
        {
            if(objEmp.Name != null)
            {
                Db.Employees.Add(objEmp);
                Db.SaveChanges();
                return RedirectToAction("Index", "Employee");
            }
            return View();
        }


        // GET: Employee/Edit/5
        public ActionResult Edit(string id)
        {
            int empId = Convert.ToInt32(id);
            var emp = Db.Employees.Find(empId);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Employee objEmp)
        {
            var data = Db.Employees.Find(objEmp.Empid);
            if (data != null)
            {
                data.Name = objEmp.Name;
                data.Address = objEmp.Address;
                data.City = objEmp.City;
                data.Age = objEmp.Age;
                data.Salary = objEmp.Salary;
            }
            Db.SaveChanges();
            return RedirectToAction("Index", "Employee");
        }



        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            int empId = Convert.ToInt32(id);
            var emp = Db.Employees.Find(empId);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Delete(int id, string confirmationMsg)
        {
            int EmpId = Convert.ToInt32(id);
            var emp = Db.Employees.Find(EmpId);

            if (emp == null)
                return View("NotFound");

            Db.Employees.Remove(emp);
            Db.SaveChanges();

            return RedirectToAction("Index", "Employee");
        }

    }
}
