using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

using Stream.DAL.EntityFramework;
using Stream.DAL.Facade;

namespace Stream.IoC
{
    public class DataContextInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IUnitOfWork>().ImplementedBy<CoreDataContext>().LifestyleTransient());
        }
    }
}