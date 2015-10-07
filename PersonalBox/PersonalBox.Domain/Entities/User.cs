using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBox.Domain.Entities
{
   public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserIdentityId { get; set; }
        public bool Status { get; set; }
        public User()
        {
            Status = true;
        }
    }
}
