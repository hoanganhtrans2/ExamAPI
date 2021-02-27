using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBase
{
    public interface IProceduceRepository
    {
        IEnumerable<Question> GetQuestions(int levelId, int numberQuestion);
    }
}
