using System;
using System.Collections.Generic;
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

            var caregoryService = new DataService<Category, EntityFrameworkRepository<Guid, Category, GuidIdInitializer>>(uow, repo);

            var newCategory = caregoryService.Add(new Category
            {
                Name = "Computres",
                Categories = new List<Category>
                {
                    new Category { Name = "-DeskTops" },
                    new Category { Name = "-Servers" },
                    new Category { Name = "-Laptops", Categories = new List<Category>
                        {
                            new Category { Name = "--Tablets" },
                            new Category { Name = "--Shmablets" },
                        }
                    },
                }
            });

            var justAdded = caregoryService.Get(c => c.Id == newCategory.Id);
            Assert.AreEqual(justAdded.Categories.Count, newCategory.Categories.Count);

            caregoryService.Remove(justAdded);
            justAdded = caregoryService.Get(c => c.Id == newCategory.Id);
            Assert.IsNull(justAdded);
        }
    }
}