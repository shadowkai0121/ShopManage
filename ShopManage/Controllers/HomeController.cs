using ShopManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopManage.Controllers
{
    public class HomeController : Controller
    {
        SMIT09Entities db = new SMIT09Entities();

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

            var query = from o in db.Orders
                        select o;


            return View();
        }


        // GET: SingleProduct
        public ActionResult SingleProduct()
        {
            var query = from o in db.OrderDetails
                        orderby o.Quantity descending
                        select o;

            return View(query.ToList());
        }

        //[HttpPost]
        //public ActionResult SingleProduct(Order order)
        //{
        //    //var query = from o in db.OrderDetails
        //    //            select o;
        //    //return Json(query, JsonRequestBehavior.AllowGet);
        //    return View();
        //}




    }
}