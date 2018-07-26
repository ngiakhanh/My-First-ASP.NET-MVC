using BLOG_ValueObject.EntityObject;
using BLOG_Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG_Controller
{
    public class UserControllers: BaseControllers<UserObject>
    {
        public override List<UserObject> getElements()
        {
            return new UserModels().getElements();
        }

        public override UserObject getElementById(Guid id)
        {
            return new UserModels().getElementById(id);
        }

        public override bool update(UserObject obj)
        {
            return new UserModels().update(obj);
        }

        public override bool create(UserObject obj)
        {
            return new UserModels().create(obj);
        }

        public override bool delete(Guid id)
        {
            return new UserModels().delete(id);
        }

        public override UserObject checkLogin(string userName, string passWord)
        {
            return new UserModels().checkLogin(userName, passWord);
        }

        public override List<UserObject> getdeletedElements()
        {
            return new UserModels().getdeletedElements();
        }

        public override bool deletePermanently(Guid id)
        {
            return new UserModels().deletePermanently(id);
        }

        public override bool restore(Guid id)
        {
            return new UserModels().restore(id);
        }
    }
}
