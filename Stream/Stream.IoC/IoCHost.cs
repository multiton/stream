using Castle.Windsor;

using Stream.IoC.Facade;
using Stream.IoC.Installer;

namespace Stream.IoC
{
    public sealed class IoCHost : IObjectResolvable
    {
        private static readonly object SyncRoot = new object();

        private readonly IWindsorContainer container;

        private static volatile IoCHost instance;

        public static IObjectResolvable Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (SyncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new IoCHost();
                        }
                    }
                }

                return instance;
            }
        }

        private IoCHost()
        {
            this.container = new WindsorContainer();
            this.Register();
        }

        private void Register()
        {
            this.container.Install(
                new DataContextInstaller(),
                new RepositoryInstaller(),
                new ServiceInstaller());
        }

        public T Get<T>()
        {
            return this.container.Resolve<T>();
        }
    }
}