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
            return JsonConvert.SerializeObject(regionSales());
        }

        public int?[] DrawDomain(int steps = 2)
        {
            int?[] domain = new int?[steps];
            domain[0] = regionSales().Values.Min();
            domain[steps - 1] = regionSales().Values.Max();
            int? range = domain[steps - 1] - domain[0];
            if (steps > 2)
            {
                for (int i = 1; i < steps - 1; i++)
                {
                    domain[i] = domain[0] + (i / steps) * range;
                }
            }

            return domain;
        }

        private Dictionary<string, int?> regionSales()
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

            return data;
        }
    }
}