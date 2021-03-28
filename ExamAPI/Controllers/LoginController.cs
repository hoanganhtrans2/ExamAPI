using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;

namespace ExamAPI.Controllers
{
    public class LoginController : ApiController
    {
        public IHttpActionResult GetInfo()
        {
            try
            {
                var identity = (ClaimsIdentity)User.Identity;
                IEnumerable<Claim> claims = identity.Claims;
                TaiKhoanDTO tk = new TaiKhoanDTO
                {
                    TaiKhoanId = Int32.Parse(identity.FindFirst("UserId").Value),
                    Ten = identity.FindFirst("UserName").Value,
                    GioiTinh = Boolean.Parse(identity.FindFirst("Gender").Value),
                    SoDienThoai = identity.FindFirst("Phone").Value,
                    NgaySinh = DateTime.Parse(identity.FindFirst("BirthDay").Value),
                    Email = identity.FindFirst("Email").Value,
                    RoleId = int.Parse(identity.FindFirst("RoleId").Value)
                };
                return Ok(tk);
            }
            catch (Exception)
            {

                return InternalServerError(new Exception(ErrConstant.CANT_GET_DATA));
            }
        }
    }
}
