using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.ViewModel;

namespace WebApplication1.Controllers
{
    public class AdminController : Controller
    {

        BLLEmployee ble = new BLLEmployee();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RegisterEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterEmployee(EmployeeViewModel evm)
        {
       
                ble.CreateEmployee(evm);
                return RedirectToAction("Index");       
        }

        public ActionResult Logout()
        {
            return RedirectToAction("Login", "Account");
        }
        public ActionResult GetAllEmployee()
        {
            ble.GetAllEmployees();
            return View(ble.GetAllEmployees());
        }
        public ActionResult Edit(int id =0)
        {
            EmployeeViewModel ev = ble.GetAllEmployees().Where(a => a.EmployeeID == id).FirstOrDefault();
            return View(ev);
        }
        [HttpPost]
        public ActionResult Edit(EmployeeViewModel ev)
        {
            ble.UpdateEmployee(ev);
            return RedirectToAction("GetAllEmployee");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            List<EmployeeViewModel> lstu = ble.GetAllEmployees();
            var users = lstu.Where(a => a.EmployeeID == id).FirstOrDefault();
            return View(users);

        }
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete_post(int id)
        {
            ble.DeleteUser(id);
            return RedirectToAction("Index");

        }




    }
}