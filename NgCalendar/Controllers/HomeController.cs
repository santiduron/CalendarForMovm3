﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NgCalendar.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
		public JsonResult GetEvents()
		{
			//Here MyDatabaseEntities is our entity datacontext (see Step 4)
			using (MyModel dc = new MyModel())
			{
				var v = dc.Events.OrderBy(a => a.StartAt).ToList();
				return new JsonResult { Data = v, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
			}
		}
	}
}