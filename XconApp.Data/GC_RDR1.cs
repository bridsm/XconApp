//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XconApp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class GC_RDR1
    {
        public int DocNum { get; set; }
        public int LineNum { get; set; }
        public string ItemCode { get; set; }
        public string Dscription { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Currency { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public string WhsCode { get; set; }
        public Nullable<decimal> PriceBefDi { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string OcrCode { get; set; }
        public string Project { get; set; }
        public Nullable<decimal> VatPrcnt { get; set; }
        public string VatGroup { get; set; }
        public Nullable<decimal> PriceAfVAT { get; set; }
        public Nullable<decimal> VatSum { get; set; }
        public string TaxCode { get; set; }
        public string TaxType { get; set; }
        public string FreeTxt { get; set; }
        public string unitMsr { get; set; }
        public string UomCode { get; set; }
        public string FromWhsCod { get; set; }
        public string Doc_LineDesc { get; set; }
        public string Doc_SizeColor { get; set; }
        public string Doc_Status { get; set; }
        public string Doc_Remark { get; set; }
    }
}
