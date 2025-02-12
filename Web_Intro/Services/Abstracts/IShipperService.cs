using Web_Intro.DTO.ShipperDTO;
using Web_Intro.Entities;

namespace Web_Intro.Services.Abstracts
{
    public interface IShipperService
    {
        List<Shipper> Add(ShipperDto shipper);   
        Shipper GetById(int id);
        List<Shipper> GetAll();
        bool Delete(int id);    
        Shipper Update(ShipperDto shipper);    

    }
}
