using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<int> RoleId { get; set; }
        public Nullable<System.DateTime> CreateOn { get; set; }

        //public virtual ICollection<Attend> Attends { get; set; }
        //public virtual Role Role { get; set; }
    }
}
