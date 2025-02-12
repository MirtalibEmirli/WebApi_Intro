using Web_Intro.Context;
using Web_Intro.Entities;
using Web_Intro.Repositories.Abstracts;

namespace Web_Intro.Repositories.Concretes;

public class ShipperRepository(EcommerceDbContext context) : IShipperRepository
{
    private readonly EcommerceDbContext _context = context;
    public void Add(Shipper shipper)
    {
        _context.Add(shipper);
        _context.SaveChanges(); 
    }

    public void Delete(int shipperId)
    {
        var shipper = GetByShipperId(shipperId);
        _context.Shippers.Remove(shipper);
        _context.SaveChanges();

    }

    public IQueryable<Shipper> GetAll()
    {
        return _context.Shippers;
    }

    public Shipper GetByShipperId(int id)
    {
        var shipper = _context.Shippers.FirstOrDefault(s => s.ShipperID == id); return shipper;
    }

    public void Update(Shipper shipper)
    {
        _context.Update(shipper);
        _context.SaveChanges();

    }
}
