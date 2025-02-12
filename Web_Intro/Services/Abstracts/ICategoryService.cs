using Web_Intro.DTO.CategoryDTO;
using Web_Intro.DTO.CustomerDtos;
using Web_Intro.Entities;

namespace Web_Intro.Services.Abstracts;

public interface ICategoryService
{
    Category Add(CategoryDTO categoryDTO);
    bool Delete(int id);
    Category GetById(int id);
    bool Update(CategoryDTO category);
    List<Category> GetAll();
}
