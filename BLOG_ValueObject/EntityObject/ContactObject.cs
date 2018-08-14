using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG_ValueObject.EntityObject
{
    public class ContactObject
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Mobile { get; set; }
        public string Message { get; set; }
        public System.DateTime Created_at { get; set; }
        public System.Guid idName { get; set; }
    }
}
