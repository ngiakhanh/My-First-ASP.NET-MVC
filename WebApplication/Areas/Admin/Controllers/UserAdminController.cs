using BLOG_ValueObject.EntityObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLOG_Controller;
using BLOG_ValueObject.Common;

namespace WebApplication.Areas.Admin.Controllers
{
    public class UserAdminController : Controller
    {
        // GET: Admin/UserAdmin
        public ActionResult UserAdminShowListIndex(int pageIndex=0)
        {
            int pageSize = CommonConstant.PAGESIZE;
            int count = new UserControllers().getNumber();
            ViewBag.maxPage = (count/pageSize) - (count%pageSize == 0 ? 1: 0);
            ViewBag.Page = pageSize;
            return View(new UserControllers().getPaging(pageIndex * pageSize, pageSize));
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

        [HttpGet]
        public ActionResult UserAdminSearch()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserAdminSearch(FormCollection f, int pageIndex = 0)
        {
            String email = f["txtkeyString"].ToString();
            int pageSize = CommonConstant.PAGESIZE;
            int count = new UserControllers().searchCount(email);
            ViewBag.maxPage = (count / pageSize) - (count % pageSize == 0 ? 1 : 0);
            ViewBag.Page = pageSize;
            ViewBag.query = email;
            return View(new UserControllers().searchPaging(email, pageIndex * pageSize, pageSize));
        }

        [HttpGet]
        public ActionResult UserAdminSearchTable()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserAdminSearchTable(String email, int pageIndex)
        {
            int pageSize = CommonConstant.PAGESIZE;
            ViewBag.Page = pageSize;
            return View(new UserControllers().searchPaging(email, pageIndex * pageSize, pageSize));
        }

        [HttpGet]
        public ActionResult UserAdminCreateMulti()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserAdminCreateMulti(List<UserObject> data)
        {
            foreach (var item in data)
            {
                if (checkUser(item.userName))
                {
                    new UserControllers().create(item);
                }
            }
            return RedirectToAction("UserAdminShowListIndex");
        }

        public Boolean checkUser(String userName)
        {
            IEnumerable<UserObject> lstUser = new UserControllers().getElements().Where(a => a.userName == userName);
            if (lstUser.Count() == 0)
            {
                return true;
            }
            return false;
        }
    }
}