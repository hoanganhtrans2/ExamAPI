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
    
    public partial class Answer
    {
        public int AttendId { get; set; }
        public int ExamDetailId { get; set; }
        public int OptionId { get; set; }
    
        public virtual Attend Attend { get; set; }
        public virtual ExamDetail ExamDetail { get; set; }
        public virtual Option Option { get; set; }
    }
}
