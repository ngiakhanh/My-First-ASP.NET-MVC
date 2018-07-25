using BLOG_ValueObject.EntityObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLOG_Controller;

namespace WebApplication.Areas.Admin.Controllers
{
    public class UserAdminController : BaseController
    {
        // GET: Admin/UserAdmin
        public ActionResult UserAdminShowListIndex()
        {
            return View(new UserControllers().getElements());
        }

        [HttpGet]
        public ActionResult UserAdminCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserAdminCreate(UserObject obj)
        {
            new UserControllers().create(obj);
            return RedirectToAction("UserAdminShowListIndex");
        }

        [HttpGet]
        public ActionResult UserAdminUpdate(Guid id)
        {
            return View(new UserControllers().getElementById(id));
        }

        [HttpPost]
        public ActionResult UserAdminUpdate(UserObject obj)
        {
            new UserControllers().update(obj);
            return RedirectToAction("UserAdminShowListIndex");
        }

        public JsonResult UserAdminDelete(Guid id)
        {
            return Json(new UserControllers().delete(id));
        }
    }
}