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
            return siList;
        }
    }
}