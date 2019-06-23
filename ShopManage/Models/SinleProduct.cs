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

            int? QuantityID1;

            Dictionary<int?, int?> data = new Dictionary<int?, int?>();


            foreach (var item in countList)
            {
                var i = 1;

                if (data.Keys.Contains(item.ProductID))
                {
                    data[item.UnitPrice] += item.UnitPrice;
                }

                //if (item.ProductID == 1)
                //{
                //    QuantityID1 = 0;

                //    QuantityID1 = QuantityID1 + (item.Quantity);
                //}


            }








            return countList;
        }




    }
}