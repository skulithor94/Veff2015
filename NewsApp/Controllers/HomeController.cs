using NewsApp.DAL;
using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsApp.Controllers
{
    public class HomeController : Controller
    {
        NewsRepository repo = new NewsRepository();

        public ActionResult Index()
        {
            var news = repo.GetAllNews();
            return View(news);
        }

        public ActionResult Create()
        {
            return View(new NewsItem());
        }

        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            NewsItem news = new NewsItem();
            UpdateModel(news);
            NewsContext context = new NewsContext();

            context.News.Add(news);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}