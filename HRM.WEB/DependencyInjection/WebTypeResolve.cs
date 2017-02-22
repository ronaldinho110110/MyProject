using System.Data.Entity;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using HRM.DAL.DbContext;
using HRM.Web.DependencyInjection;
using HRM.DAL;

using HRM.DAL.Repository.TeamRepository;

namespace HRM.Web
{
    public class WebTypeResolver : IWebTypeResolver
    {
        public void RegisterType(IUnityContainer container)
        {
            container.RegisterType<DbContext, HRMContext>(new InjectionConstructor());
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IUserRepository, UserRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ITeamRepository, TeamRepository>(new HierarchicalLifetimeManager());
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}