﻿using System.Configuration;
using System.Web.Mvc;
using System.Web.Services.Description;
using MagicBag.Models;

namespace MagicBag.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index()
        {
            var model = new GreetingViewModel();
            model.Message = ConfigurationManager.AppSettings["message"];
            return View();
        }
    }
}