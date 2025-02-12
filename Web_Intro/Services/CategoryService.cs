using Web_Intro.DTO.CategoryDTO;
using Web_Intro.Entities;
using Web_Intro.Repositories.Abstracts;

namespace Web_Intro.Services;

public class CategoryService(ICategoryRepository categoryRepository) : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository = categoryRepository;
    public Category Add(CategoryDTO categoryDTO)
    {
        if (categoryDTO != null)
        {
            var category = new Category
            {
                CategoryName = categoryDTO.Name,
            
            };
            _categoryRepository.Add(category);
            return category;

        }
        else
        {
            return new Category { };//bu duz deyl eslnde messasge gedmelidi
        }

    }

    public bool Delete(int id)
    {
        _categoryRepository.Delete(id);
        return true;

    }

    public List<Category> GetAll()
    {
        return _categoryRepository.GetAll().ToList();
    }

    public Category GetById(int id)
    {
        return _categoryRepository.GetbyId(id);
    }

    public bool Update(CategoryDTO category)

    {
        var mainC = _categoryRepository.GetbyId(category.Id);
        mainC.CategoryName = category.Name;
        _categoryRepository.Update(mainC);
       
        return true;
    }
}
