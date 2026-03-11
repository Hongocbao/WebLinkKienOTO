using WebLinkKienOTO.Models;

namespace WebLinkKienOTO.Repositories
{
    public class MockProductRepository : IProductRepository
    {
        
        private static List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Link kiện ôTô", Price = 1000, Description = "A high-end laptop", CategoryId = 1, ImageUrl = "/images/products/laptop.jpg" }
        };

        public IEnumerable<Product> GetAll() => _products;

        public Product? GetById(int id) => _products.FirstOrDefault(p => p.Id == id);

        public void Add(Product product)
        {
           
            product.Id = _products.Any() ? _products.Max(p => p.Id) + 1 : 1;
            _products.Add(product);
        }

        public void Update(Product product)
        {
            var existing = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existing != null)
            {
                existing.Name = product.Name;
                existing.Price = product.Price;
                existing.Description = product.Description;
                existing.CategoryId = product.CategoryId;
                existing.ImageUrl = product.ImageUrl;
            }
        }

        public void Delete(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null) _products.Remove(product);
        }
    }
}