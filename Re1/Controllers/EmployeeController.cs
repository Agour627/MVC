using Re1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Re1.Controllers
{
    public class EmployeeController : Controller
    {
        CompanyContext db;
        public EmployeeController()
        {
            db = new CompanyContext();
        }
        public ActionResult Index()
        {
            var AllEmps = db.Employees.ToList();
            return View(AllEmps);
        }
    }
}