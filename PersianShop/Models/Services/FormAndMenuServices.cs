using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersianShop.Models.Services
{
	public class FormAndMenuServices
	{
        public int MenuID { get; set; }
        public int SubSystemID { get; set; }
        public string SubSystemName { get; set; }
        public string MenuName { get; set; }
        public int ParentMenuID { get; set; }
        public int FormID { get; set; }
        public int FormName { get; set; }
        public int Order { get; set; }
    }
}