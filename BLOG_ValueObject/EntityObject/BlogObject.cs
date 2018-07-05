using BLOG_ValueObject.EntityObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG_ValueObject.EntityObject
{
    public class BlogObject
    {
        public System.Guid idBlog { get; set; }
        public string title { get; set; }
        public string summury { get; set; }
        public string contents { get; set; }
        public string author { get; set; }
        public Nullable<System.Guid> idUser { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public Nullable<bool> isDel { get; set; }
        public UserObject UserObject { get; set; }
    }
}
