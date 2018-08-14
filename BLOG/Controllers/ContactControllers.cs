using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLOG_Controller;
using BLOG_ValueObject.EntityObject;
using BLOG_Model.Model;
namespace BLOG_Controller
{
    public class ContactControllers: BaseControllers<ContactObject>
    {
        public bool insert(ContactObject obj)
        {
            return new ContactModels().insert(obj);
        }
    }
}
