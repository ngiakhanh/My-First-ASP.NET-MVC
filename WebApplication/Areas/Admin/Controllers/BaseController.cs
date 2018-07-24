using BLOG_ValueObject.Common;
using BLOG_ValueObject.EntityObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace WebApplication.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        protected UserObject objUser { get; set; }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            objUser = (UserObject)Session[CommonConstant.SESSION_USER];
            if (objUser == null)
            {
                // Chưa đăng nhập => quay lại Đăng nhập
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Login", action = "Login", Area = "Admin" }));
            }
            else
            {
                //Phân quyền
            }
            base.OnActionExecuting(filterContext);
        }

        public ActionResult LogOut()
        {
            Session.Remove(CommonConstant.SESSION_USER);
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
    }
}