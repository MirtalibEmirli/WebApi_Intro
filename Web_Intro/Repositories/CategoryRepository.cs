using Web_Intro.Context;
using Web_Intro.Entities;
using Web_Intro.Repositories.Abstracts;

namespace Web_Intro.Repositories;

public class CategoryRepository(EcommerceDbContext dbContext) : ICategoryRepository
{
    private readonly EcommerceDbContext _context = dbContext;
    public void Add(Category category)
    {
        _context.Add(category);
        _context.SaveChanges();
    }

    public void Delete(int categoryId)
    {
        var category = _context.Categories.FirstOrDefault(c => c.CategoryID == categoryId);
        _context.Remove(category);
        _context.SaveChanges();
    }

    public IQueryable<Category> GetAll()
    {
     return   _context.Categories;
    }

    public Category GetbyId(int id)
    {
      return  _context.Categories.FirstOrDefault(c => c.CategoryID == id);
    }

    public void Update(Category category)
    {
        _context.Update(category);
        _context.SaveChanges();

    }
}
