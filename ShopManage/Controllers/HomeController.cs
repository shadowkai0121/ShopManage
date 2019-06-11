using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ShopManage.Models;
namespace ShopManage.Controllers
{
    public class HomeController : Controller
    {
        DataCleaning dc = new DataCleaning();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Month
        public ActionResult Month()
        {
            return View();
        }

        // GET: Region
        public ActionResult Region()
        {
            return View(dc.RegionSales());
        }

        // GET: SingleProduct
        public ActionResult SingleProduct()
        {
            return View();
        }
    }
}