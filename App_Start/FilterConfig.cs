using MVCTutorials9AM.Extensions;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorials9AM
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new LogActionFilter());
            filters.Add(new HandleErrorAttribute());

        }
    }
}
