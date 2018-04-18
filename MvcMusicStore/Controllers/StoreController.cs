﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        public ActionResult Index()
        {
            return View();
        }
        //public string Index()
        //{
        //    return "Hello from Store.Index()";
        //}
        public string browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return message;
        }
        public string Details(int id)   
        {
            string message = HttpUtility.HtmlDecode("Store.Details, ID = "+ id);
            return message;
        }
	}
}