using AutoMapper;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Role, RoleDTO>();
            CreateMap<Level, LevelDTO>();
            CreateMap<Option, OptionDTO>();
            CreateMap<ExamDetail, ExamDetailDTO>();         
            CreateMap<Attend, AttendDTO>();
            CreateMap<Answer, AnswerDTO>();
            CreateMap<ExamInfo, ExamInfoDTO>();            
            CreateMap<Question, QuestionDTO>();            
            CreateMap<User, UserDTO>();
        }
    }
}
