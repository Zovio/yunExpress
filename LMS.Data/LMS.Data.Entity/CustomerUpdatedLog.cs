//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Data.Entity
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using LighTake.Infrastructure.Seedwork;
    
    public partial class CustomerUpdatedLog : Entity
    {
        public virtual Nullable<System.Guid> CustomerID { get; set; }
        public virtual string CustomerCode { get; set; }
        public virtual Nullable<int> PaymentTypeID { get; set; }
        public virtual Nullable<bool> EnableCredit { get; set; }
        public virtual Nullable<decimal> MaxDelinquentAmounts { get; set; }
        public virtual string ChangedBy { get; set; }
        public virtual Nullable<System.DateTime> UpdatedOn { get; set; }
        public virtual int ID { get; set; }
    }
}