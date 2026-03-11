using WebLinkKienOTO.Models;

namespace WebLinkKienOTO.Repositories
{
    public class MockCategoryRepository : ICategoryRepository
    {
        private readonly List<Category> _categoryList;

        public MockCategoryRepository()
        {
            _categoryList = new List<Category>
            {
                new Category { Id = 1, Name = "Phụ kiện ô tô" },
                new Category { Id = 2, Name = "Bánh xe" },
                new Category { Id = 3, Name = "Cánh gió" }
            };
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryList;
        }
    }
}