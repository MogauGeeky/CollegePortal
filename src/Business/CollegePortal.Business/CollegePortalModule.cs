using Autofac;
using CollegePortal.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegePortal.Business
{
    public class CollegePortalModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<CollegePortalDbContext>().AsSelf().InstancePerLifetimeScope();

            builder.RegisterType<CollegePortalDataFactory>()
                .As<ICollegePortalDataFactory>().InstancePerLifetimeScope();

            builder.RegisterType<CollegePortalManager>()
                .As<ICollegePortalManager>().InstancePerLifetimeScope();
        }
    }
}
