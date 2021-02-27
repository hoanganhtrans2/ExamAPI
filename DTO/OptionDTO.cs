using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OptionDTO
    {
        public int OptionId { get; set; }
        public string Title { get; set; }
        public Nullable<int> QuestionId { get; set; }

      //  public  QuestionDTO Question { get; set; }
       // public  ICollection<AnswerDTO> Answers { get; set; }
    }
}
