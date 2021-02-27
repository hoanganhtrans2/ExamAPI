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
        IGenericService<Question> service = null;
        IMapper mapper = null;
        public QuestionController(IGenericService<Question> genericService)
        {
            this.service = genericService;
            mapper = ConfigMapper.Config();
        }
        public IHttpActionResult GetAllQuestion()
        {
            try
            {
                IEnumerable<Question> result = service.GetAll();
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
