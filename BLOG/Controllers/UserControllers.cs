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
            return new UserModel().getElements();
        }

        public override UserObject getElementById(Guid id)
        {
            return new UserModel().getElementById(id);
        }

        public override bool update(UserObject obj)
        {
            return new UserModel().update(obj);
        }

        public override bool create(UserObject obj)
        {
            return new UserModel().create(obj);
        }

        public override bool delete(Guid id)
        {
            return new UserModel().delete(id);
        }

        public override UserObject checkLogin(string userName, string passWord)
        {
            return new UserModel().checkLogin(userName, passWord);
        }
    }
}
