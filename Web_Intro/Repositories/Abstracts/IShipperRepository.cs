using Web_Intro.Entities;

namespace Web_Intro.Repositories.Abstracts;

public interface IShipperRepository
{
    public void Add(Shipper shipper);
    public void Update(Shipper shipper);
    public void Delete(Shipper shipper);    
    public Shipper GetByShipperId(int id);
   public IQueryable<Shipper> GetAll();   
}
