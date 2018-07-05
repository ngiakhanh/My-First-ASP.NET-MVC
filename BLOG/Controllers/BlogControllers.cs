using BLOG_Model.Model;
using BLOG_ValueObject.EntityObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG.Controllers
{
    class BlogControllers : BaseControllers<BlogObject>
    {
        public override List<BlogObject> getElements()
        {
            return new BlogModels().getElements();
        }

        public override BlogObject getElementById(Guid id)
        {
            return base.getElementById(id);
        }

        public override bool update(BlogObject obj)
        {
            return base.update(obj);
        }

        public override bool create(BlogObject obj)
        {
            return base.create(obj);
        }

        public override bool delete(Guid id)
        {
            return base.delete(id);
        }
    }
}
