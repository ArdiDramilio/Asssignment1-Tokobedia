//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class HeaderTran
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HeaderTran()
        {
            this.DetailTrans = new HashSet<DetailTran>();
        }
    
        public string TransactionID { get; set; }
        public string UserID { get; set; }
        public System.DateTime TransactionDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailTran> DetailTrans { get; set; }
        public virtual MsUser MsUser { get; set; }
    }
}
