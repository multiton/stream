using Castle.Windsor;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;

using Microsoft.Data.Entity;

using Stream.DAL.EntityFramework;

namespace Stream.IoC.Installer
{
    public class DataContextInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<DbContext>().ImplementedBy<CoreDataContext>().LifestyleTransient());
        }
    }
}