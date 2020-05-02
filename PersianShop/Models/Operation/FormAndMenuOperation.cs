using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersianShop.Models.Operation
{
	public class FormAndMenuOperation
	{
		public static List<PersianShop.Models.Services.FormAndMenuServices> ReturnMenus()
		{
			using (var context = new PersianShop.Models.PersianEntities())
			{
				long vCode = context.overal_setting.Where(o => o.id == 64).Select(o => o.value).FirstOrDefault();
				PersianShop.Models.Enums.VersionName ProgramVersion = (PersianShop.Models.Enums.VersionName)vCode;
				var ResultAllMenu = context.Menu.Include("Form").Include("Form.UserFormPermissions").Where(m => ((ProgramVersion == PersianShop.Models.Enums.VersionName.ForshgahiNoskheKamelTakLine ? m.Form.v1 == true : ProgramVersion == PersianShop.Models.Enums.VersionName.OmdeForoshSonatiTakLine ? m.Form.v2 == true : ProgramVersion == PersianShop.Models.Enums.VersionName.MooyragiTakLine ? m.Form.v3 == true : ProgramVersion == PersianShop.Models.Enums.VersionName.MooyragiChandLine ? m.Form.v4 == true : ProgramVersion == PersianShop.Models.Enums.VersionName.ForshgahiNoskheKamelChandLine ? m.Form.v5 == true : ProgramVersion == PersianShop.Models.Enums.VersionName.OmdeForoshSonatiChandLine ? m.Form.v6 == true : 1 == 1) | m.FormID == null)).ToList();
				return (from read in ResultAllMenu
						select new PersianShop.Models.Services.FormAndMenuServices
						{
							FormID = read.FormID ?? 0,
							MenuName = read.Text,
							MenuID = read.MenuID,
							Order = read.order ?? 0,
							ParentMenuID = read.ParentMenuID ?? 0,
							SubSystemID = read.SubSystemID ?? 0,
						}).ToList();
			}
		}
		public static List<PersianShop.Models.Services.FormAndMenuServices> ReturnSubSystems()
		{
			using (var context = new PersianShop.Models.PersianEntities())
			{
				return (from read in context.SubSystem
						select new PersianShop.Models.Services.FormAndMenuServices
						{
							SubSystemID = read.SubSystemId,
							SubSystemName = read.Name,
						}).ToList();
			}
		}
	}
}