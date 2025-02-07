using Web_Intro.DTO.CustomerDtos;
using Web_Intro.Entities;
using Web_Intro.Repositories;

namespace Web_Intro.Services
{
    public class CustomerService(ICustomerRepository customerRepository) : IcustomerService
    {
        private readonly ICustomerRepository _customerRepository = customerRepository;
        public Customer Add(AddDto customer)
        {
            var newCustomer = new Customer() { CustomerId = customer.CustomerId, CompanyName = customer.CompanyName };
            _customerRepository.Add(newCustomer);
            return newCustomer;
        }

        public bool Delete(Customer customer)
        {
            _customerRepository.Delete(customer);
            return true;
        }

        public List<Customer> GetAll()
        {
            var list = _customerRepository.GetAll();
            return [.. list];
        
        }

        public Customer GetbyId(string id)
        {
            var current = _customerRepository.GetbyId(id);
            if (current!=null)
            {
                return current;

            }
            return null;
        }

        public bool Update(string customerid)
        {

            _customerRepository.Update(customerid);
            return true;
        }
    }
}
