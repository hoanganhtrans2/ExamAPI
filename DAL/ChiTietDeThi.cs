//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietDeThi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChiTietDeThi()
        {
            this.CauTraLois = new HashSet<CauTraLoi>();
        }
    
        public int ChiTietDeThiId { get; set; }
        public Nullable<int> DeThiId { get; set; }
        public Nullable<int> CauHoiId { get; set; }
        public Nullable<int> LastUpdateBy { get; set; }
        public Nullable<System.DateTime> LastUpdateOn { get; set; }
    
        public virtual CauHoi CauHoi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CauTraLoi> CauTraLois { get; set; }
        public virtual DeThi DeThi { get; set; }
    }
}
