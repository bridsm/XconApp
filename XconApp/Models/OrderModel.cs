using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XconApp.Models
{
    public class OrderModel
    {
        public int DocEntry { get; set; }
        public Nullable<int> DocNum { get; set; }
        public string DocDate { get; set; }
        public string EndDate { get; set; }
        public string RangeDateType { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string ProjectName { get; set; }
        public string ProjectCode { get; set; }
        public string DocCur { get; set; }
        public Nullable<decimal> DocRate { get; set; }
        public string Address { get; set; }

        public IList<OrderDetailModel> OrderDetails { get; set; }
    }
}