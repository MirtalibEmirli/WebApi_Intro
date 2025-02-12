using Microsoft.AspNetCore.Mvc;
using Web_Intro.DTO.CategoryDTO;
using Web_Intro.Entities;
using Web_Intro.Services;

namespace Web_Intro.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController(ICategoryService categoryService) : Controller
{
    private readonly ICategoryService _categoryService = categoryService;

    [HttpGet]
    //[Route("getallbycategory")]
    public List<Category> GetAll()
    {
        return _categoryService.GetAll();
    }
    [HttpGet]
    //[HttpGet("{id}")] //bu usulla ya aftomatk route edmelisen 
    [Route("getbyid")]//yada rout vermelisen ayri cunki basa duse bilmirki men hansi get methodunu esas olaraq qebu; edm
    public Category GetById(int id)
    {
      return  _categoryService.GetById(id);
    }
    [HttpPost]
    public Category Add([FromBody] CategoryDTO categoryDTO)
    {
        return _categoryService.Add(categoryDTO);

    }
    [HttpDelete] 
    public IActionResult Delete(int id)
    {
        _categoryService.Delete(id);
        return Ok();
    }
    [HttpPut]
    public IActionResult Update(CategoryDTO category)
    {

        _categoryService.Update(category);
        return Ok();

    }
}


