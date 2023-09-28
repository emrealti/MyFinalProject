using Entities.Concrete;

namespace DateAccess.Abstract
{
    public interface ICategoryDal1
    {
        void Add(Category categoryt);
        void Delete(Category category);
        List<Category> GetAll();
        List<Category> GetAllByCategory(int categoryId);
        void Update(Category category);
    }
}