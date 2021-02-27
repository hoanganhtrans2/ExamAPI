using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace InterfaceBase
{
    public interface IQuestion
    {
        IEnumerable<Question> GetQuestions(int levelId, int numberQuestion);
    }
}
