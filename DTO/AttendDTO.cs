using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AttendDTO
    {
        public int ExamInfoId { get; set; }
        public int UserId { get; set; }
        public Nullable<double> Point { get; set; }
        public int AttendId { get; set; }
        public Nullable<int> SubmitIn { get; set; }

        //public virtual ICollection<Answer> Answers { get; set; }
        //public virtual ExamInfo ExamInfo { get; set; }
        //public virtual User User { get; set; }
    }
}
