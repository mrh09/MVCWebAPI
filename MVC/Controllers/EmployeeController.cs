using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            IEnumerable<EmployeeModel> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Employees").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<EmployeeModel>>().Result;
            return View(empList);
        }

        [HttpGet]
        public ActionResult Add(int id = 0)
        {
            if ( id == 0)
                return View(new EmployeeModel());
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Employees/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<EmployeeModel>().Result);
            }
        }

        [HttpPost]
        public ActionResult Add(EmployeeModel emp)
        {
            if (emp.EmployeeId == 0)
            { 
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Employees", emp).Result;
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Employees/"+emp.EmployeeId, emp).Result;
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int employeeid)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Employees/"+ employeeid.ToString()).Result;
            return RedirectToAction("Index");
        }
    }
}