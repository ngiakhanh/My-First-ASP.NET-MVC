using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLOG_Controller;
using BLOG_ValueObject.EntityObject;

namespace WebApplication.Areas.Admin.Controllers
{
    public class BlogAdminController : BaseController
    {
        // GET: Admin/BlogAdmin
        public ActionResult BlogAdminShowListIndex()
        {
            ViewBag.username = objUser.userName;
            return View(new BlogControllers().getElements());
        }

        [HttpGet]
        public ActionResult BlogAdminCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult BlogAdminCreate(BlogObject obj)
        {
            obj.idUser = objUser.idUser;
            obj.UserObject.userName = objUser.userName;
            new BlogControllers().create(obj);
            return RedirectToAction("BlogAdminShowListIndex");
        }

        [HttpGet]
        public ActionResult BlogAdminUpdate(Guid id)
        {

            return View(new BlogControllers().getElementById(id));
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult BlogAdminUpdate(BlogObject obj)
        {
            new BlogControllers().update(obj);
            return RedirectToAction("BlogAdminShowListIndex");
        }

        public JsonResult BlogAdminDelete(Guid id)
        {
            return Json(new BlogControllers().delete(id));
        }
    }
}