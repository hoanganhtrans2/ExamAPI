using AutoMapper;
using DAL;
using DTO;
using InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TransferObject;

namespace ExamAPI.Controllers
{
    public class QuestionController : ApiController
    {
        IGenericService<Question> genericService = null;
        IQuestion service = null;
        IMapper mapper = null;
        public QuestionController(IGenericService<Question> genericService, IQuestion service)
        {
            this.genericService = genericService;
            this.service = service;
            mapper = ConfigMapper.Config();
        }
        public IHttpActionResult GetAllQuestion()
        {
            try
            {
                IEnumerable<Question> result = service.GetQuestions(1, 20);
                IEnumerable<QuestionDTO> response = mapper.Map<IEnumerable<Question>, IEnumerable<QuestionDTO>>(result);
                return Ok(response);
            }
            catch (Exception err)
            {
                return InternalServerError(new Exception(ErrConstant.CANT_GET_DATA));
            }

        }
    }
}
