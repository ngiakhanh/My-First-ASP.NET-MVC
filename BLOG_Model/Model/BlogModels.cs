using BLOG_ValueObject.EntityObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG_Model.Model
{
    public class BlogModels : BaseModels<BlogObject>
    {
        public override List<BlogObject> getElements()
        {
            var listData = dbContext.SP_Blog_getElements();

            List<BlogObject> listBlog = new List<BlogObject>();
            foreach (var item in listData)
            {
                BlogObject obj = new BlogObject();
                obj.idBlog = item.idBlog;
                obj.title = item.title;
                obj.summury = item.summury;
                obj.contents = item.contents;
                obj.author = item.author;
                obj.idUser = item.idUser;
                obj.created_at = item.created_at;
                obj.updated_at = item.updated_at;
                obj.isDel = item.isDel;
                //obj.UserObject = item.UserObject;
                listBlog.Add(obj);
            }
            return listBlog;
        }

        public override BlogObject getElementById(Guid id)
        {
            var data = dbContext.SP_Blog_getElementById(id);
            foreach (var item in data)
            {
                BlogObject obj = new BlogObject();
                obj.idBlog = item.idBlog;
                obj.title = item.title;
                obj.summury = item.summury;
                obj.contents = item.contents;
                obj.author = item.author;
                obj.idUser = item.idUser;
                obj.created_at = item.created_at;
                obj.updated_at = item.updated_at;
                obj.isDel = item.isDel;
                //obj.UserObject = item.UserObject;
                return obj;
            }
            return null;
        }

        public override bool update(BlogObject obj)
        {
            try
            {
                return dbContext.SP_Blog_update(obj.idBlog, obj.title, obj.summury, obj.contents, obj.author, obj.idUser, obj.created_at, DateTime.Now, false) > 0;

            }
            catch
            {
                return false;
            }
        }

        public override bool create(BlogObject obj)
        {
            try
            {
                return dbContext.SP_Blog_update(obj.idBlog, obj.title, obj.summury, obj.contents, obj.author, obj.idUser, obj.created_at, DateTime.Now, false) > 0;
 
            }
            catch
            {
                return false;
            }
        }

        public override bool delete(Guid id)
        {
            return dbContext.SP_Blog_delete(id) > 0;
        }
    }
}

