﻿using System.Web;
using System.Web.Mvc;

namespace CS_P149_NewsletterApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
