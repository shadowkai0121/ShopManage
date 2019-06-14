using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Rootobject
{
    public Class1[] Property1 { get; set; }
}

public class Class1
{
    public string OrderID { get; set; }
    public DateTime OrderDate { get; set; }
    public int MemberID { get; set; }
    public int TotalPrice { get; set; }
    public string ReceiverName { get; set; }
    public string ReceiverPhone { get; set; }
    public string ReceiverAddress { get; set; }
}

namespace ShopManage.Models
{
    public class Class1
    {
    }
}