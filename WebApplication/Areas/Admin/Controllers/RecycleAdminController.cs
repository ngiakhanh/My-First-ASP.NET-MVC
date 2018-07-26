using BLOG_Controller;
using BLOG_ValueObject.EntityObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Areas.Admin.Controllers
{
    public class RecycleAdminController : BaseController
    {
        // GET: Admin/Recycle
        public ActionResult RecycleAdminShowListIndexUser()
        {
            return View(new UserControllers().getdeletedElements());
        }

        public ActionResult RecycleAdminShowListIndexBlog()
        {
            return View(new BlogControllers().getdeletedElements());
        }

        public JsonResult RecycleAdminRestoreUser(Guid id)
        {
            return Json(new UserControllers().restore(id));
        }

        public JsonResult RecycleAdminRestoreBlog(Guid id)
        {
            return Json(new BlogControllers().restore(id));
        }

        public JsonResult RecycleAdminDeletePermanentlyUser(Guid id)
        {
            return Json(new UserControllers().deletePermanently(id));
        }

        public JsonResult RecycleAdminDeletePermanentlyBlog(Guid id)
        {
            return Json(new BlogControllers().deletePermanently(id));
        }

    }
}