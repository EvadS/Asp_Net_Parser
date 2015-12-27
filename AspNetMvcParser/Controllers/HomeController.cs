using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMvcParser.Models;

namespace AspNetMvcParser.Controllers
{
    public class HomeController : Controller
    {
        private const string url__ = "http://opera.odessa.ua/ru/o-teatre/istoriya/";
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Parser parser = new Parser();

            parser.Url = url__;

           DataRow  row  =  parser.Parse();

           return View(row);
        }

    }
}
