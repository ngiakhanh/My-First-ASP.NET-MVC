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
                BlogObject obj = new BlogObject
                {
                    idBlog = item.idBlog,
                    title = item.title,
                    summury = item.summury,
                    contents = item.contents,
                    author = item.author,
                    idUser = item.idUser,
                    created_at = item.created_at,
                    updated_at = item.updated_at,
                    isDel = item.isDel,
                    UserObject = new UserObject()
                    {
                        userName = item.userName,
                    }
                };
                ;
                listBlog.Add(obj);
            }
            return listBlog;
        }

        public override BlogObject getElementById(Guid id)
        {
            var data = dbContext.SP_Blog_getElementById(id);
            foreach (var item in data)
            {
                BlogObject obj = new BlogObject
                {
                    idBlog = item.idBlog,
                    title = item.title,
                    summury = item.summury,
                    contents = item.contents,
                    author = item.author,
                    idUser = item.idUser,
                    created_at = item.created_at,
                    updated_at = item.updated_at,
                    isDel = item.isDel,
                    UserObject = new UserObject()
                    {
                        userName = item.userName,
                        fullName = item.fullName,
                    }
                };

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
                return dbContext.SP_Blog_create(Guid.NewGuid(), obj.title, obj.summury, obj.contents, obj.author, obj.idUser, DateTime.Now, DateTime.Now, false) > 0;
 
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

