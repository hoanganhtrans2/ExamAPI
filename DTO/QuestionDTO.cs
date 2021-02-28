using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuestionDTO
    {
        public int QuestionId { get; set; }
        public string QuestionContent { get; set; }
        public Nullable<int> LevelId { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateOn { get; set; }
        public Nullable<int> LastUpDateBy { get; set; }
        public Nullable<System.DateTime> LastUpDateOn { get; set; }
        public Nullable<int> OptionId { get; set; }
        public Nullable<bool> Deleted { get; set; }

        //public virtual ICollection<ExamDetail> ExamDetails { get; set; }
        //public virtual Level Level { get; set; }
        public  List<OptionDTO> Options { get; set; }
    }
}
