using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ExamInfoDTO
    {
        public int ExamInfoId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Time { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateOn { get; set; }
        public Nullable<int> LevelId { get; set; }

        //public virtual ICollection<Attend> Attends { get; set; }
        //public virtual ICollection<ExamDetail> ExamDetails { get; set; }
        //public virtual Level Level { get; set; }
    }
}
