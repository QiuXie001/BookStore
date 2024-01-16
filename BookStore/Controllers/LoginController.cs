using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using BookStore.DBStandard.Models;

namespace BookStore.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string ID, string Password)
        {
            if (ModelState.IsValid)
            {
                DBContext db = new DBContext();
                int Id = int.Parse(ID);
                if (ID[..1] == "1")
                {
                    Admin? admin = db.Admin.SingleOrDefault(a => a.Id.ToString() == ID);
                    if (admin != null && admin.Password == Password)
                    {
                        HttpContext.Session.SetString("isLogin", "true");
                        HttpContext.Session.SetString("identity", "admin");
                        return RedirectToAction("MainBoard", "Main");
                    }
                    else
                    {
                        return View();
                    }
                }
                else
                {
                    Custom? custom = db.Custom.SingleOrDefault(a => a.Id == Id);
                    if (custom != null && custom.Password == Password)
                    {
                        HttpContext.Session.SetString("isLogin", "true");
                        HttpContext.Session.SetString("identity", "custom");
                        return RedirectToAction("MainBoard", "Main");
                    }
                    else
                    {
                        return View();
                    }
                }
            }
            else return View();
        }
        [HttpPost]
        public ActionResult Regist(Custom entry)
        {
            if (ModelState.IsValid)
            {
                Domain.Service.CustomService.Register(entry);
                HttpContext.Session.SetString("isLogin", "true");
                HttpContext.Session.SetString("identity", "custom");
                return RedirectToAction("MainBoard", "Main");
            }
            return View("Login");
        }
    }
}
