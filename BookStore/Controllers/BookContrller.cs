using BookStore.DBStandard.Models;
using BookStore.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult BookList()
        {
            var books = BookService.GetAll();
            var types = BookTypeService.GetAll();
            ViewBag.types = types;
            return View(books);
        }

        [HttpPost]
        public ActionResult BookList(string str)
        {
            return View();
        }
    }
}