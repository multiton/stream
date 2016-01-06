using Microsoft.VisualStudio.TestTools.UnitTesting;

using Stream.IoC;
using Stream.Repository.Facade.Product;

namespace Stream.IntegrationTest.Product
{
    [TestClass]
    public class CategoryTest
    {
        [TestMethod]
        public void AddRemoveCategory()
        {
            var categoryRepository = IoCHost.IocHost.Get<ICategoryRepository>();
        }
    }
}