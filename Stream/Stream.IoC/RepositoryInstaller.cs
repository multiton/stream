using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

using Stream.Domain.Entity.Product;
using Stream.Repository.Facade;

namespace Stream.IoC
{
    class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Types.FromAssembly(typeof(Item).Assembly)
                .BasedOn(typeof(IGenericRepository<>))
                .LifestyleTransient());
        }
    }
}