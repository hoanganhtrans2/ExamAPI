
using DAL;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace ExamAPI
{
    public class ApplicationOAuthProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            using(var ctx = new ThiTiengAnhDbContext())
            {
                var user = ctx.TaiKhoans.Where(u => u.Email == context.UserName && u.Password == context.Password).FirstOrDefault();
                if(user!= null)
                {
                    identity.AddClaim(new Claim("UserId", user.TaiKhoanId.ToString()));
                    identity.AddClaim(new Claim("UserName", user.Ten));
                    identity.AddClaim(new Claim("Gender", user.GioiTinh.ToString()));
                    identity.AddClaim(new Claim("Phone", user.SoDienThoai));
                    identity.AddClaim(new Claim("BirthDay", user.NgaySinh.ToString()));
                    identity.AddClaim(new Claim("Email", user.Email));
                    identity.AddClaim(new Claim("RoleId", user.RoleId.ToString()));
                    context.Validated(identity);
                }
                else
                {
                    context.SetError("wrong Credtials", "some thing worng");
                    return;
                }    
            }
        }
    }
}