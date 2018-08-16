using System.Web;
using System.Web.Mvc;

namespace Cuentas_De_Ahorro_BD_P1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
