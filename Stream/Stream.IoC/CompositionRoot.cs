using Castle.Windsor;

namespace Stream.IoC
{
    public static class CompositionRoot
    {        
        public static void ConfigureContainer()
        {
            var container = new WindsorContainer();

            container.Install(
                new DataContextInstaller(),
                new RepositoryInstaller(),
                new ServiceInstaller());
        }
    }
}