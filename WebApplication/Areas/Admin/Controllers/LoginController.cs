using BLOG_ValueObject.EntityObject;
using BLOG_ValueObject.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BLOG_Controller;


namespace WebApplication.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(UserObject obj)
        {
            UserObject user = new UserControllers().checkLogin(obj.userName, obj.passWord);

            if (ModelState.IsValid)
            {
                if (user!=null)
                {
                    //Session
                    Session.Add(CommonConstant.SESSION_USER, user);

                    //Cookie
                    FormsAuthentication.SetAuthCookie(user.userName, user.Remember);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Login error!");
                }
            }
           
            return View();
        }
    }
}