using BLOG_Model.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG_Model.Model
{
    public class BaseModels<T>
    {
        protected Y2018AP51BLOGEntities dbContext;

        public BaseModels()
        {
            dbContext = new Y2018AP51BLOGEntities();
        }

        public virtual List<T> getElements() { return null; }
        public virtual T getElementById(Guid id) { return default(T); }
        public virtual Boolean create(T obj) { return true; }
        public virtual Boolean update(T obj) { return true; }
        public virtual Boolean delete(Guid id) { return true; }
        public virtual T checkLogin(String userName, String passWord) { return default(T); }
    }

}