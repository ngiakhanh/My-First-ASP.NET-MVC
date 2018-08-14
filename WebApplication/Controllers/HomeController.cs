using BLOG_ValueObject.EntityObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLOG_Controller;
using BLOG_ValueObject.Common;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int pageIndex=0)
        {
            int pageSize = CommonConstant.PAGESIZE;
            int count = new BlogControllers().getNumber();
            ViewBag.maxPage = (count / pageSize) - (count % pageSize == 0 ? 1 : 0);
            return View(new BlogControllers().getPaging(pageIndex * pageSize, pageSize));
        }

        public ActionResult Detail(Guid id)
        {
            return View(new BlogControllers().getElementById(id));
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactObject obj)
        {
            new ContactControllers().insert(obj);
            return RedirectToAction("Contact");
        }
    }
}