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
    
    public partial class PhieuDuThi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuDuThi()
        {
            this.CauTraLois = new HashSet<CauTraLoi>();
        }
    
        public int PhieuDuThiId { get; set; }
        public Nullable<int> TaiKhoanId { get; set; }
        public Nullable<int> CaThiId { get; set; }
    
        public virtual CaThi CaThi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CauTraLoi> CauTraLois { get; set; }
        public virtual PhieuKetQua PhieuKetQua { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
