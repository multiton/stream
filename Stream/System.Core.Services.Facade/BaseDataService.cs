using Stream.DAL.Facade;

namespace System.Core.Services.Facade
{
    public abstract class BaseEntityFrameworkDataService : IDisposable
    {
        // ToDo: Pending.
        // private readonly EntityFrameworkRepository<TId, TEntity, TIdInitializer> Repository;

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