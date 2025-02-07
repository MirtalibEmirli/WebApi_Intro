using Web_Intro.DTO.CustomerDtos;
using Web_Intro.Entities;

namespace Web_Intro.Services;

public interface IcustomerService
{
    Customer Add(AddDto customer);
    bool Delete(Customer customer);
    bool Update(string customerid);
    Customer GetbyId(string id);
   List<Customer> GetAll();
}

