using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ShopManage.Models
{
    public class mCustomerSatisfaction
    {
        SMIT09Entities db = new SMIT09Entities();

        public List<Satisfaction> GetSmileIndex()
        {
            var query = from o in db.Satisfactions
                        orderby o.desk, o.id descending
                        select o;
            var siList = query.ToList();
            for (int i = 0; i < siList.Count; i++)
            {
                if (i != 0)
                {
                    while (siList[i].desk == siList[i - 1].desk)
                    {
                        siList.RemoveAt(i);
                    }
                }
            }
            return siList;
        }
    }
}