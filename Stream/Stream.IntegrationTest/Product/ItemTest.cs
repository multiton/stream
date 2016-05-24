using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stream.DAL.EntityFramework;

using Stream.Domain.Entity.Product;
using Stream.Repository;

namespace Stream.IntegrationTest.Product
{
    [TestClass]
    public class ItemTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var uow = new EntityFrameworkUnitOfWork(new CoreDataContext());

            uow.GetDbSet<Item>();
        }
    }
}