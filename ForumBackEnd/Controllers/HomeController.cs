﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForumBackEnd.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		public ActionResult Index(string b)
		{
			ViewBag.Title = "Home Page";

			return View();
		}
		[Route("Home/HelloThere/Index/")]
		public ActionResult Index()
		{

			return View();
		}
	}
}
