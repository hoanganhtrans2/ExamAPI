using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LevelDTO
    {
        public int LevelId { get; set; }
        public string Title { get; set; }

        //public virtual ICollection<ExamInfo> ExamInfoes { get; set; }
        //public virtual ICollection<Question> Questions { get; set; }
    }
}
