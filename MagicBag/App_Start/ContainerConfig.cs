using System.Web.Mvc;
using System.Web.Razor.Generator;
using Autofac;
using Autofac.Integration.Mvc;
using MagicBag.Data.Services;

namespace MagicBag
{
    public class ContainerConfig
    {
        public static void RegisterContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<InMemoryBagData>()
                .As<IBagData>()
                .SingleInstance();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}