using Castle.Windsor;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;

using Stream.Repository;
using Stream.Repository.Facade;

namespace Stream.IoC.Installer
{
    class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register
            (
                Types.FromAssembly
                (
                    typeof(EntityFrameworkRepository<,,>).Assembly
                )
                .BasedOn
                (
                    typeof(ICreatable<>),
                    typeof(IModifiable<>),
                    typeof(IFindable<>)
                )
                .WithServiceAllInterfaces()
                .LifestylePerWebRequest()
            );
        }
    }
}