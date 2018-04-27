using Autofac;
using Autofac.Integration.WebApi;
using DemographicChangeData.DAL;
using demographicChangeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace demographicChange.Autofac
{
    public static class AutofacDependencyBuilder
    {
        public static void DependencyBuilder()
        {
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterWebApiFilterProvider(config);
            builder.RegisterWebApiModelBinderProvider();

            builder.RegisterType<DemographicChangeRepository>().As<IDemographicChangeRepository>();
            builder.RegisterType<DemographicChangeService>().As<IDemographicChangeService>();

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}