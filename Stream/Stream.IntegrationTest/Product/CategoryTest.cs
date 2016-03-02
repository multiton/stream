using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stream.Domain.Entity.Product;
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
            // How to Resolve ???
            // var categoryRepository = IoCHost.Instance.Get<ICategoryRepository<Category, Guid>>();
        }
    }
}