using Web_Intro.Entities;

namespace Web_Intro.Repositories.Abstracts
{
    public interface ICustomerRepository
    {
        void Add(Customer customer);
        void Delete(string customerid);
        void Update(string customerid);
        Customer GetbyId(string id);
        IQueryable<Customer> GetAll();
    }
}
