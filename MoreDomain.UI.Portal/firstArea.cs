using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MoreDomain.UI.Portal
{
    public class firstArea:AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "fi";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute("fi", "fi/{controller}/{action}");
        }
    }
}