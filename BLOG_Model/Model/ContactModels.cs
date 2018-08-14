using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLOG_ValueObject.EntityObject;
namespace BLOG_Model.Model
{
    public class ContactModels : BaseModels<ContactObject>
    {
        public bool insert(ContactObject obj)
        {
            try
            {
                return dbContext.SP_Contact_Insert(Guid.NewGuid(), obj.Name, obj.Email, obj.Mobile, obj.Message, DateTime.Now) > 0;

            }
            catch
            {
                return false;
            }
        }
    }
}
