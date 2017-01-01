using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XconApp.Models
{
    public class OrderDetailModel
    {
        public string U_GC_GroupType { get; set; }
        public string ItemCode { get; set; }
        public string Dscription { get; set; }
        public string CanEditChild { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string U_Size { get; set; }
        public string U_Color { get; set; }
    }
}