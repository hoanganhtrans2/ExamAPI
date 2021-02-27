using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ExamDetailDTO
    {
        public Nullable<int> QuestionId { get; set; }
        public Nullable<int> ExamInfoId { get; set; }
        public int ExamDetailId { get; set; }
        //public virtual ICollection<Answer> Answers { get; set; }
        //public virtual ExamInfo ExamInfo { get; set; }
        //public virtual Question Question { get; set; }
    }
}
