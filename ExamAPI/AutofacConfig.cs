using Autofac;
using Autofac.Integration.WebApi;
using InterfaceBase;
using Repository;
using ServiceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace ExamAPI
{
    public static class AutofacConfig
    {
        public static void Config()
        {
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<ProceduceRepository>().As<IProceduceRepository>();
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(GenericService<>)).As(typeof(IGenericService<>)).InstancePerLifetimeScope();           
            builder.RegisterAssemblyTypes(typeof(QuestionService).Assembly)
                   .Where(t => t.Name.EndsWith("Service"))
                   .AsImplementedInterfaces()
                   .InstancePerRequest();
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}