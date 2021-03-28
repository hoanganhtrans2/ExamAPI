using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class TaiKhoanDTO
    {
        public int TaiKhoanId { get; set; }
        public string Ten { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<int> RoleId { get; set; }
    }
}
