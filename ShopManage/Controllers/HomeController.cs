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
            TempData["RegionSales"] = dc.RegionSales();
            return View();
        }

        // GET: SingleProduct
        public ActionResult SingleProduct()
        {
            //SMIT09Entities db = new SMIT09Entities();


            //var query = from o in db.OrderDetails
            //            orderby o.ProductID
            //            select o;

            SinleProduct ss = new SinleProduct();
           

            List<OrderDetail> countList = ss.GetCount();


            return View(countList);
        }

        //顧客滿意度
        public ActionResult CustomerSatisfaction()
        {
            mCustomerSatisfaction cs = new mCustomerSatisfaction();
            List<Satisfaction> siList = cs.GetSmileIndex();

            return View(siList);
        }
        
    }
}