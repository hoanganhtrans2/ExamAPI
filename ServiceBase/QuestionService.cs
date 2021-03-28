using DAL;
using InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBase
{
    public class QuestionService: IQuestion
    {
        IProceduceRepository service = null;
        public QuestionService(IProceduceRepository service)
        {
            this.service = service;
        }

        //public IEnumerable<Question> GetQuestions(int levelId, int numberQuestion)
        //{
        //    return service.GetQuestions(levelId, numberQuestion);
        //}
    }
}
