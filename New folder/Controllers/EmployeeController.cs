using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication8;

namespace WebApplication8.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Add()
        {
            EmployeeModel model = new EmployeeModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(EmployeeModel m)
        {
           if(ModelState.IsValid)
            {
                ViewBag.msg = "Employee Created:" + m.FirstName;
            }

            /* if (m.FirstName.Length > 5)
             {

                 ViewBag.msg = "Employee Created:" + m.FirstName;
             }
             else
             {
                 //ViewBag.msg="Length must be more than 9";
                 ModelState.AddModelError("FirstName", "Length must be more than 5");
                 return View(m);
             }*/
            return View(m);

        }
    }
}