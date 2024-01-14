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
            DBContext db = new DBContext();
            int Id = int.Parse(ID);
            if (ID[..1] == "1")
            {
                // Admin admin = db.Admins.SingleOrDefault(a => a.AdminId.ToString() == ID);
                // //if (account.Password == password)
                // //    Debug.WriteLine("Í¨¹ý");
                // if (admin != null && admin.AdminPassword == Password)
                // {
                //     HttpContext.Session.SetString("isLogin", "true");
                //     Response.Clear();
                //     return RedirectToAction("MainBoard", "Main");
                // }
                // else
                // {
                //     TempData["identity"] = "manager";
                //     return View();
                // }
                return View("MainBoard", "Main");
            }
            else
            {
                Custom? custom = db.Custom.SingleOrDefault(a => a.Id == Id);
                if (custom != null && custom.Password == Password)
                {
                    HttpContext.Session.SetString("isLogin", "true");
                    Response.Clear();
                    return RedirectToAction("MainBoard", "Main");
                }
                else
                {
                    TempData["identity"] = "custom";
                    return View();
                }
            }
        }
        [HttpPost]
        public ActionResult Regist(Custom entry)
        {
            if (ModelState.IsValid)
            {
                Domain.Service.CustomService.Register(entry);
                HttpContext.Session.SetString("isLogin", "true");
                return RedirectToAction("MainBoard", "Main");
            }
            return View("Login");
        }
    }
}
