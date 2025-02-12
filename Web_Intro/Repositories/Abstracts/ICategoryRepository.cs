using Web_Intro.Entities;

namespace Web_Intro.Repositories.Abstracts
{
    public interface ICategoryRepository
    {
        void Add(Category category);
        void Delete(int categoryId);
        void Update(Category category);
        Category GetbyId(int id);
        IQueryable<Category> GetAll();
    }
}
