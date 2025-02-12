using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Intro.DTO.CustomerDtos;
using Web_Intro.Entities;
using Web_Intro.Services.Abstracts;

namespace Web_Intro.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController(IcustomerService service) : ControllerBase
{
    private readonly IcustomerService _customerService = service;
    [HttpPost]
    public IActionResult AddCustomer([FromBody] AddDto customer)
    {
        var newCustomer = _customerService.Add(customer);
        return Ok(newCustomer);

    }

    [HttpGet]
    public List<Customer> GetAll()
    {
        var list = _customerService.GetAll();
        return list;
    }

     
    [HttpGet("{id}")]  
     public IActionResult GetById(string Id) 
    { 
        var current = _customerService.GetbyId(Id); 
        return Ok(current); 
    }

    [HttpPut]
    public IActionResult Update([FromBody]string id)
    {
        _customerService.Update(id);
        return Ok();
    }
    [HttpDelete]
    public IActionResult Delete(string id)
    {
        _customerService.Delete(id);
        return Ok();
    }

}


