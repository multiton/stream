using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Stream.Core.Services;
using Stream.DAL.EntityFramework;
using Stream.Domain.Entity.Facade;
using Stream.Domain.Entity.Product;
using Stream.Repository;

namespace Stream.IntegrationTest.Product
{
    [TestClass]
    public class CategoryTest
    {
        [TestMethod]
        public void AddRemoveCategory()
        {
            var context = new CoreDataContext();
            var uow = new EntityFrameworkUnitOfWork(context);

            var repo = new EntityFrameworkRepository<Guid, Category, GuidIdInitializer>(context);

            var caregoryService = new DataService<
                Category,
                EntityFrameworkRepository<Guid, Category, GuidIdInitializer>>(uow, repo);

            var newCategory = caregoryService.Add(new Category() { Name = "Computres" });

            var existingCategory = caregoryService.Get(c => c.Id == newCategory.Id);

            Assert.IsNotNull(existingCategory);
        }
    }
}