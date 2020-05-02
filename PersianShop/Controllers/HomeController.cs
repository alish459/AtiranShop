using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersianShop.Controllers
{
	// اگر نام ويو با نام متد يكي نباشد ميتوان داخل پرانتز نام ويو را قيد كرد
	public class HomeController : Controller
	{
		// GET: Home
		public ActionResult Index()
		{

			return View(PersianShop.Models.Operation.FormAndMenuOperation.ReturnSubSystems());
		}
		public ActionResult ContactUs()
		{
			return View();
		}
		public ActionResult AboutUs(string Name, string Family, int? age)
		{
			if (age != null && age < 13)
			{
				ViewBag.Message = "گم ورو";
				return View("_Message");
			}
			ViewBag.Name = Name;
			ViewBag.Family = Family;
			return View();
		}
		public ActionResult WorkWithID(int id = 0)
		{
			ViewBag.id = id;
			return View();
		}
		public ActionResult _MainPartial()
		{
			ViewBag.site = "www.toplearn.com";
			return PartialView();
		}
		[ChildActionOnly]
		public ActionResult LoadPartila(int Id = 0)
		{
			if (Id == 1)
			{
				ViewBag.site = "1";
				return PartialView("_MainPartial");
			}
			else if (Id == 2)
			{
				ViewBag.site = "2";
				return PartialView("_MainPartial");
			}
			return null;
		}
		// در صورتي كه از رندر بادي استفاده كنيم، بايد مشخص كنيم كه كه لي اوتو ويو مورد نظر چيست و ققط در جايي كه رندر بادي خورده است ميتوان در ويو كد نوشت و كد نوشته شده در قيمت رندر بادي مينشيند
		// رندر سكشن براي موقعي است كه ميخواهيم بخشي از سايت چيز ديگري اضافه شود و در تمام صفحات نباشد
		public ActionResult TestLayOut()
		{
			return View();
		}
		public ActionResult ShowCustAct()
		{
			var MyModel = PersianShop.Models.Operation.CustomerOperation.ReturnCustomersOperations();
			return View(MyModel);
		}
		public ActionResult F12()
		{
			return View(PersianShop.Models.Operation.FormAndMenuOperation.ReturnSubSystems());
		}
	}
}
/*
@{
	Layout = "~/Views/Shared/_LayoutFirstPage1.cshtml";
}

@*اكشن لينك از روتي كه در اپ استارت قرار داده شده است پيروي ميكند*@
@Html.ActionLink("Contact Us", "ContactUs", "Home");
<br />
@Html.ActionLink("About Us", "AboutUs", "Home");
<br />
@Html.ActionLink("Work With ID", "WorkWithID", "Home")
<br />
@Html.ActionLink("Test LayOut", "TestLayOut", "Home")
<br />
@Html.ActionLink("Customers Operation", "ShowCustAct", "Home")
<br />
<form action="/Home/AboutUs" method="post">
	Name : <input type="text" name="Name" />
	Family : <input type="text" name="Family" value="" />
	Age : <input type="number" name="Age" value="" />
	<input type="submit" value="Save" />
</form>
@Html.Action("_MainPartial", "Home")
@Html.Action("LoadPartila", "Home");*/
