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
    
    public partial class GC_OREC
    {
        public int DocNum { get; set; }
        public Nullable<int> LineNum { get; set; }
        public string DocStatus { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string TypePay { get; set; }
        public string Bank { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Project { get; set; }
        public string U_MainProject { get; set; }
        public string AttachFile { get; set; }
    }
}