using Web_Intro.DTO.ShipperDTO;
using Web_Intro.Entities;
using Web_Intro.Repositories.Abstracts;
using Web_Intro.Services.Abstracts;

namespace Web_Intro.Services.Concretes;

public class ShipperService(IShipperRepository shipperRepository) : IShipperService
{
    private readonly IShipperRepository _shipperRepository=shipperRepository; 
    public List<Shipper> Add(ShipperDto shipper)
    {
        var shipperM = new Shipper{
        CompanyName=shipper.Name,
        Phone=shipper.Phone,

        };
        _shipperRepository.Add(shipperM);   
        return _shipperRepository.GetAll().ToList();
    }

    public bool Delete(int id)
    {
        var sp= GetById(id);
        _shipperRepository.Delete(sp);
        return true;    
    }

    public List<Shipper> GetAll()
    {
        return _shipperRepository.GetAll().ToList();

    }

    public Shipper GetById(int id)
    {
        return _shipperRepository.GetByShipperId(id);
    }

    public Shipper Update(ShipperDto shipper)
    {
        var shipperM = _shipperRepository.GetByShipperId(shipper.Id);
        shipperM.CompanyName=shipper.Name;  
        shipperM.Phone=shipper.Phone;   
        _shipperRepository.Update
            (shipperM); 
        return shipperM;    
    }
}
