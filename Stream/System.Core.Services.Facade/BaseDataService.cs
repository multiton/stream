using System;
using Stream.DAL.Facade;

namespace Stream.Core.Services.Facade
{
    public abstract class BaseDataService : IDisposable
    {
        protected readonly IUnitOfWork UnitOfWork;

        protected BaseDataService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.UnitOfWork.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}