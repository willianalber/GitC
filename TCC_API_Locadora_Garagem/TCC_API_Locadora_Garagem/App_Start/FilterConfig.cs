using System.Web;
using System.Web.Mvc;

namespace TCC_API_Locadora_Garagem
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
