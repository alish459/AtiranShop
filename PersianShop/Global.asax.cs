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
        // ��� �� ����� ���� �� ��� ���� ���� ���ʡ ���� ����� ��� ��� ��� ���� �����
        protected void Application_Start()
        {
            //================= ��� �� �� ���� ���� ����� �� ���� ����� � ��� ������� �� ����� ����� �� �� ��� ���� ������� ������
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());
            //=================
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
