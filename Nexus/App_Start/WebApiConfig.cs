using System.Web.Http;

namespace Nexus
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            
            config.EnableCors();
            // Web API configuration and services
            if (!AppGlobal.InitConfig())
            {
                Logger.Write("Khong init duoc config!",true);
                return;
            }
            if (!AppGlobal.InitMemory())
            {
                Logger.Write("Khong init duoc du lieu!");
                return;
            }
//            if (!AppGlobal.InitUserPermission("Init Start Services"))
//            {
//                Logger.Write("Khong init duoc permission!");
//                return;
//            }
            
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
