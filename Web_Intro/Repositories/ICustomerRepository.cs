using Web_Intro.Entities;

namespace Web_Intro.Repositories;

public interface ICustomerRepository
{   void Add(Customer customer);
    void Delete(Customer customer);
    void Update(string customerid);
    Customer GetbyId(string id);
    IQueryable<Customer> GetAll();
}