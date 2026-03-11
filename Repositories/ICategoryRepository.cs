using WebLinkKienOTO.Models;

namespace WebLinkKienOTO.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}
