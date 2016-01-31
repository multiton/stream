using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

using Stream.Domain.Entity.Product;
using Stream.Repository.Facade;

namespace Stream.IoC.Installer
{
    class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            // ToDo: How to register ???
            //container.Register(
            //    Types.FromAssembly(typeof(Item).Assembly)
            //    .BasedOn(typeof(EntityFrameworkGenericRepository<,,>))
            //    .LifestyleTransient());
        }
    }
}