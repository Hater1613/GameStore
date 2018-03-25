using Autofac;
using GameStore.BusinessLogicLayer.Abstract;
using GameStore.BusinessLogicLayer.Services;
using GameStore.Domain.Abstract;
using GameStore.Domain.EF;
using GameStore.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.AutofacRegistrations
{
    public class GlobalRegistrations
    {
        public static ContainerBuilder ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterType<GameStoreContext>().As<IDbContext>().WithParameter("connection", "DefaultConnection");
            builder.RegisterType<GameService>().As<IGameService>();
            return builder;
        }
    }
}
