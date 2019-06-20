using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopManage.Models
{
    public class SinleProduct
    {
            SMIT09Entities db = new SMIT09Entities();

        public List<OrderDetail> GetCount()
        {
            var queryID = from o in db.OrderDetails
                          orderby o.ProductID
                          select o;









            var countList = queryID.ToList();
            return countList;
        }




    }
}