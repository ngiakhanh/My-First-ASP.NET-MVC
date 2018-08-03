using BLOG_Model.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG_Controller
{
    public class BaseControllers<T>
    {
        public virtual List<T> getElements() { return null; }
        public virtual T getElementById(Guid id) { return default(T); }
        public virtual Boolean create(T obj) { return true; }
        public virtual Boolean update(T obj) { return true; }
        public virtual Boolean delete(Guid id) { return true; }
        public virtual T checkLogin(String userName, String passWord) { return default(T); }
        public virtual Boolean deletePermanently(Guid id) { return true; }
        public virtual List<T> getdeletedElements() { return null; }
        public virtual Boolean restore(Guid id) { return true; }
        public virtual int getNumber() { return 0; }
        public virtual List<T> getPaging(int start, int length) { return null; }
        public virtual List<T> search(String email) { return null; }
        public virtual List<T> searchPaging(String email, int start, int length) { return null; }
        public virtual int searchCount(String email) { return 0; }
    }
}
