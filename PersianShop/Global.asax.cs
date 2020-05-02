using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PersianShop
{
    public class MvcApplication : System.Web.HttpApplication
    {
        // ÈÚÏ ÇÒ Çíäßå Ñæå ÈÑ Ñæí ÓÑæÑ ŞÑÇÑ ÑİÊ¡ ÈÑÇí Çæáíä ÈÇÑ Çíä ãÊÏ ÇÌÑÇ ãíÔæÏ
        protected void Application_Start()
        {
            //================= Çíä Ïæ ÎØ äÍæå ÔÊä æíæåÇ ÑÇ ãÔÎÕ ãíßäÏ æ İŞØ æíæåÇíí ÑÇ ÏäÈÇá ãíÑÏÏ ßå ÇÒ Çíä ÍÇáÊ ÇÓÊİÇÏå ãíßäÏÏ
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());
            //=================
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
