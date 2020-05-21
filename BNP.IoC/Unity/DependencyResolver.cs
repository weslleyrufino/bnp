using BNP.Domain.Interfaces.Repositories;
using BNP.Domain.Interfaces.Repositories.Base;
using BNP.Domain.Interfaces.Services;
using BNP.Domain.Services;
using BNP.Infra.Persistence;
using BNP.Infra.Persistence.Repositories;
using BNP.Infra.Persistence.Repositories.Base;
using BNP.Infra.Transactions;
using Microsoft.Practices.Unity;
using prmToolkit.NotificationPattern;
using System.Data.Entity;

namespace BNP.IoC.Unity
{
    public class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {
            container.RegisterType<DbContext, BNPContext>(new HierarchicalLifetimeManager());
            //UnitOfWork
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<INotifiable, Notifiable>(new HierarchicalLifetimeManager());

            // Services
            container.RegisterType<IServiceProduto, ServiceProduto>(new HierarchicalLifetimeManager());
            container.RegisterType<IServiceProdutoCosif, ServiceProdutoCosif>(new HierarchicalLifetimeManager());
            container.RegisterType<IServiceMovimentoManual, ServiceMovimentoManual>(new HierarchicalLifetimeManager());

            //Repository
            container.RegisterType(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            container.RegisterType<IRepositoryProduto, RepositoryProduto>(new HierarchicalLifetimeManager());
            container.RegisterType<IRepositoryProdutoCosif, RepositoryProdutoCosif>(new HierarchicalLifetimeManager());
            container.RegisterType<IRepositoryMovimentoManual, RepositoryMovimentoManual>(new HierarchicalLifetimeManager());


        }
            
    }
}
