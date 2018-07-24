using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG_ValueObject.EntityObject
{
    public class UserObject
    {
        public System.Guid idUser { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; }
        public string email { get; set; }
        public string fullName { get; set; }
        public string mobile { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public Nullable<bool> isDel { get; set; }
        public Boolean Remember { get; set; }
    }
}
