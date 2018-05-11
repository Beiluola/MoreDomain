using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
namespace MoreDomain.UI.Portal
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // 视图引擎分为两类，0是webform引擎，1是mvc的razor引擎
            ViewEngines.Engines.RemoveAt(0);
            ViewEngineCollection vec = ViewEngines.Engines;
            RazorViewEngine razor = vec[0] as RazorViewEngine;

            // razor分为两种，路由和区域。
            // razor.ViewLocationFormats = new string[] { "~/Views/{1}/{0}.cshtml", "~/Views/Shared/{0}.cshtml" };
            var c = razor.AreaViewLocationFormats.ToList();
             c.Add("~/Modules/{2}/Views/{1}/{0}.cshtml");
            razor.AreaViewLocationFormats = c.ToArray();

            // 获取当前编译文件的所有路由。Core复制过来的dll文件，就会有Core的路由，删除之后就没了。
            var cccc = RouteTable.Routes;

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}