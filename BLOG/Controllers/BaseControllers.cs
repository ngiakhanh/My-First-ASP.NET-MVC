using BLOG_Model.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG.Controllers
{
    public class BaseControllers<T>
    {       
        public virtual List<T> getElements() { return null; }
        public virtual T getElementById(Guid id) { return default(T); }
        public virtual Boolean create(T obj) { return true; }
        public virtual Boolean update(T obj) { return true; }
        public virtual Boolean delete(Guid id) { return true; }
    }
}
