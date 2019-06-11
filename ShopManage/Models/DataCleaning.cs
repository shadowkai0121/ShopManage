using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopManage.Models;
using Newtonsoft.Json;
namespace ShopManage.Models
{
    public class DataCleaning
    {
        SMIT09Entities db = new SMIT09Entities();
        public string RegionSales()
        {
            Dictionary<string, int?> data = new Dictionary<string, int?>();
            var Q = db.Orders;
            foreach (var item in Q)
            {
                if (data.ContainsKey(item.ReceiverAddress))
                {
                    data[item.ReceiverAddress] += item.TotalPrice;
                }
                else
                {
                    data.Add(item.ReceiverAddress, item.TotalPrice);
                }
            }

            return JsonConvert.SerializeObject(data);
        }
    }
}