using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersianShop.Models.Operation
{
	public class CustomerOperation
	{
		public static List<Models.Services.CustomerService> ReturnCustomersOperations()
		{
			using (var context = new Models.PersianEntities())
			{
				return (from read in context.cust_act
						join readCus in context.CUSTOMERS on read.shmo equals readCus.SHMO
						select new Models.Services.CustomerService
						{
							Act_dis = read.act_dis,
							Act_id = read.act_id,
							Bed = read.act_bed,
							Bes = read.act_bes,
							Date = read.date,
							DocNumber = read.DocNumber ?? 0,
							Done_Date = read.done_date,
							Ghno = read.ghno,
							Manafter = 0,
							MoghayeratDiscription = read.MoghayeratDiscription,
							Moname = readCus.MONAME,
							Rdf_ = read.rdf_,
							Shmo = read.shmo,
							ShowInReport = read.ShowInReport,
							Status = string.Empty,
							SysID = read.sysid ?? 1,
							UserName = read.user_id
						}).OrderByDescending(a => a.Date).Take(10).ToList();
			}
		}
		public static List<Models.Services.CustomerService> ReturnCustomers()
		{
			using (var context = new Models.PersianEntities())
			{
				return (from read in context.CUSTOMERS
						select new Models.Services.CustomerService
						{
							Moname = read.MONAME,
							Tell = read.cell,
							Address = read.addre,
							Manafter = Math.Abs(read.man),
							Status = read.man > 0 ? "بدهكار" : read.man < 0 ? "بستانكار" : "--",
							Shmo = read.SHMO,
							RealManafter = read.man
						}).OrderByDescending(a => a.Shmo).Take(20).ToList();
			}
		}
	}
}