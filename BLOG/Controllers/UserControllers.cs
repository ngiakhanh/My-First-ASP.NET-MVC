using BLOG_ValueObject.EntityObject;
using BLOG_Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG.Controllers
{
    public class UserControllers: BaseControllers<UserObject>
    {
        public override List<UserObject> getElements()
        {
            return new UserModel().getElements();
        }

        public override UserObject getElementById(Guid id)
        {
            return base.getElementById(id);
        }

        public override bool update(UserObject obj)
        {
            return base.update(obj);
        }

        public override bool create(UserObject obj)
        {
            return base.create(obj);
        }

        public override bool delete(Guid id)
        {
            return base.delete(id);
        }

    }
}
