using Microsoft.AspNetCore.Http.HttpResults;
using Web_Intro.Context;
using Web_Intro.Entities;

namespace Web_Intro.Repositories;

public class CustomerRepository(EcommerceDbContext dbcontext) : ICustomerRepository
{
    private readonly EcommerceDbContext ecommerceDbContext = dbcontext;
    public void Add(Customer customer)
    {
        ecommerceDbContext.Add(customer);
        ecommerceDbContext.SaveChanges();
    }

    public void Delete(Customer customer)
    {
        ecommerceDbContext.Remove(customer);
        ecommerceDbContext.SaveChanges();
    }

 

    public Customer GetbyId(string id)
    {
        var current = ecommerceDbContext.Customers.FirstOrDefault(u => u.CustomerId == id);
        return current;
    }

    public void Update(string customerid)
    {
        var customer = ecommerceDbContext.Customers.FirstOrDefault(u => u.CustomerId == customerid);
        ecommerceDbContext.Update(customer);
        ecommerceDbContext.SaveChanges();
    }

    IQueryable<Customer> ICustomerRepository.GetAll()
    {
        return ecommerceDbContext.Customers;
    }
}
