using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using BookStore.DBStandard;
using BookStore.DBStandard.Models;
using System.Data.Entity;

namespace BookStore.Controllers;

public class MainController : Controller
{
    // GET: Main
    public ActionResult MainBoard()
    {
        return View();
    }


}
