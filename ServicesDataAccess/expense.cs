//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicesDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class expense
    {
        public int expense_id { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<int> expense_entity_id { get; set; }
        public Nullable<int> expense_concept_id { get; set; }
        public Nullable<System.DateTime> entry_date { get; set; }
        public Nullable<int> period_id { get; set; }
        public Nullable<int> doc_number { get; set; }
        public Nullable<int> voucher_id { get; set; }
    }
}