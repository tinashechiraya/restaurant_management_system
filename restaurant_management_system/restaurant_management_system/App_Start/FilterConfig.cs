﻿using System.Web;
using System.Web.Mvc;

namespace restaurant_management_system
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
