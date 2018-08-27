using Autofac;
using AutoMapper;
using CollegePortal.Data.Context;

namespace CollegePortal.Business
{
    public class CollegePortalModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<CollegePortalDbContext>().AsSelf().InstancePerLifetimeScope();

            builder.RegisterType<CollegePortalDataFactory>()
                .As<ICollegePortalDataFactory>().InstancePerLifetimeScope();

            builder.RegisterType<CollegePortalManager>()
                .As<ICollegePortalManager>().InstancePerLifetimeScope();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MapperProfile>();
            });

            builder.Register(c => config.CreateMapper()).As<IMapper>()
                .InstancePerLifetimeScope().PropertiesAutowired().PreserveExistingDefaults();
        }
    }
}