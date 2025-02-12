using Web_Intro.DTO.ShipperDTO;
using Web_Intro.Entities;
using Web_Intro.Repositories.Abstracts;
using Web_Intro.Services.Abstracts;

namespace Web_Intro.Services.Concretes
{
    public class ShipperService(IShipperRepository shipperRepository) : IShipperService
    {
        private readonly IShipperRepository _shipperRepository=shipperRepository; 
        public List<Shipper> Add(ShipperDto shipper)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Shipper> GetAll()
        {
            throw new NotImplementedException();
        }

        public Shipper GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Shipper Update(ShipperDto shipper)
        {
            throw new NotImplementedException();
        }
    }
}
