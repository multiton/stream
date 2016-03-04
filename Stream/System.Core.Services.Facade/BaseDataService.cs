using Stream.DAL.Facade;

namespace System.Core.Services.Facade
{
    public abstract class BaseEntityFrameworkDataService : IDisposable
    {
        protected readonly IUnitOfWork UnitOfWork;

        protected BaseEntityFrameworkDataService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        public void Dispose()
        {
            this.UnitOfWork.Dispose();
        }
    }
}