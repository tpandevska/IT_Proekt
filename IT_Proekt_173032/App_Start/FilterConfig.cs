﻿using System.Web;
using System.Web.Mvc;

namespace IT_Proekt_173032
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new AuthorizeAttribute());
        }
    }
}
