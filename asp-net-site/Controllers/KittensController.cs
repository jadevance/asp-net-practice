﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp_net_site.Controllers
{
    public class KittensController : Controller
    {
        // GET: /Kittens/
        public string Index()
        {
            return "Hello from Kittens.Index()";

        }
        // GET: /Kittens/Browse?breed=?Calico
        public string Browse(string breed)
        {
            string message = HttpUtility.HtmlEncode("Kittens.Browse, Breed = " + breed);
     
            return message;
        }
        // GET: /Kittens/Details
        public string Details(int id)
        {
            string message = HttpUtility.HtmlEncode("Kittens.Details, ID = " + id);

            return message;
        }
    }
}