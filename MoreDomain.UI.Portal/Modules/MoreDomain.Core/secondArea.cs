using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoreDomain.Core
{
    public class secondArea : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "MoreDomain.Core";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute("se","se/{controller}/{action}");
        }
    }
}