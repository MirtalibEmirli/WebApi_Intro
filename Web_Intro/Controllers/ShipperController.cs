using Microsoft.AspNetCore.Mvc;
using Web_Intro.DTO.ShipperDTO;
using Web_Intro.Entities;
using Web_Intro.Services.Abstracts;

namespace Web_Intro.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ShipperController(IShipperService shipperService) : Controller
{
    private readonly IShipperService _shipperService= shipperService;   
    [HttpGet]   
    public List<Shipper> GetAll()
    {   
        return  _shipperService.GetAll();   
    }
    [HttpPost]
    public IActionResult Add(ShipperDto shipperDto)
    {
            _shipperService.Add(shipperDto);    
        return Ok(shipperDto);
    }
    [HttpPut]
    public IActionResult Update(ShipperDto shipperDto) { 
    _shipperService.Update(shipperDto); 
        return Ok(shipperDto);  
    }

    [HttpDelete]
    public IActionResult Delete(int id) { _shipperService.Delete(id); return Ok(); }

    [HttpGet("{id}")]
    public Shipper GetById(int id)
    {
        return _shipperService.GetById(id); 
    }

}
