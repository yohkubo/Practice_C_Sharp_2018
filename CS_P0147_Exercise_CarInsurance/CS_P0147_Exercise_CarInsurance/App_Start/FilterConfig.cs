using System.Web;
using System.Web.Mvc;

namespace CS_P0147_Exercise_CarInsurance
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
