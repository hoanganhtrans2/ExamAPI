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
    
    public partial class CauTraLoi
    {
        public int PhieuDuThiId { get; set; }
        public int ChiTietDeThiId { get; set; }
        public int DapAnId { get; set; }
    
        public virtual ChiTietDeThi ChiTietDeThi { get; set; }
        public virtual DapAn DapAn { get; set; }
        public virtual PhieuDuThi PhieuDuThi { get; set; }
    }
}
