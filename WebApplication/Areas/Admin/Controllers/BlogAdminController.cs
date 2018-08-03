using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLOG_Controller;
using BLOG_ValueObject.Common;
using BLOG_ValueObject.EntityObject;

namespace WebApplication.Areas.Admin.Controllers
{
    public class BlogAdminController : BaseController
    {
        // GET: Admin/BlogAdmin
        public ActionResult BlogAdminShowListIndex(int pageIndex = 0)
        {
            int pageSize = CommonConstant.PAGESIZE;
            int count = new BlogControllers().getNumber();
            ViewBag.maxPage = (count / pageSize) - (count % pageSize == 0 ? 1 : 0);
            ViewBag.Page = pageSize;
            ViewBag.username = objUser.userName;
            return View(new BlogControllers().getPaging(pageIndex * pageSize, pageSize));
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