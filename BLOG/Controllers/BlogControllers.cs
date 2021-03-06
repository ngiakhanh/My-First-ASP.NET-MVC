﻿using BLOG_Model.Model;
using BLOG_ValueObject.EntityObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG_Controller
{
    public class BlogControllers : BaseControllers<BlogObject>
    {
        public override List<BlogObject> getElements()
        {
            return new BlogModels().getElements();
        }

        public override BlogObject getElementById(Guid id)
        {
            return new BlogModels().getElementById(id);
        }

        public override bool update(BlogObject obj)
        {
            return new BlogModels().update(obj);
        }

        public override bool create(BlogObject obj)
        {
            return new BlogModels().create(obj);
        }

        public override bool delete(Guid id)
        {
            return new BlogModels().delete(id);
        }

        public override List<BlogObject> getdeletedElements()
        {
            return new BlogModels().getdeletedElements();
        }

        public override bool deletePermanently(Guid id)
        {
            return new BlogModels().deletePermanently(id);
        }

        public override bool restore(Guid id)
        {
            return new BlogModels().restore(id);
        }

        public override int getNumber()
        {
            return new BlogModels().getNumber();
        }

        public override List<BlogObject> getPaging(int start, int length)
        {
            return new BlogModels().getPaging(start, length);
        }

    }
}
