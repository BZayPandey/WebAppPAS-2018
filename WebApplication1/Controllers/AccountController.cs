using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.ViewModel;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        BLLEmployee blu = new BLLEmployee();
        UserViewModel uv = new UserViewModel();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserViewModel uv)
        {
            if (ModelState.IsValid)
            {

                using (GMSEntities2 db = new GMSEntities2())
                {
                    var obj = db.tblUsers.Where(a => a.Username ==uv.Username  && a.Password ==uv.Password).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["Userid"] = obj.Userid.ToString();
                        Session["Username"] = obj.Username.ToString();
                        
                        return RedirectToAction("Index","Admin");
                    }
                }
            }
            return View();
        }
       
        }
    }
