using Autofac;
using Autofac.Integration.Mvc;
using GameStore.AutofacRegistrations;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;

namespace GameStore.WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            DependencyResolver.SetResolver(new AutofacDependencyResolver(GlobalRegistrations.ConfigureContainer(builder).Build()));
        }
    }
}