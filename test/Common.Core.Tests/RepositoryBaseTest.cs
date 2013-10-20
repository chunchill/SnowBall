using Common.Core.Interfaces;
using Common.Infrastructure;
using NUnit.Framework;

namespace Common.Core.Tests
{
    class Product
    {
        public string ProductName { get; set; }
        public string CompanyName { get; set; }
    }

    [TestFixture]
    public class RepositoryBaseTest
    {
        [Test]
        public void can_insert_entity_to_mongolab()
        {
            var productRepository = new RepositoryBase<Product>();
            productRepository.Add(new Product
                                      {
                                          CompanyName = "hello",
                                          ProductName = "world"
                                      });

        }
    }
}