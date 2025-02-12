using Microsoft.AspNetCore.Http.HttpResults;
using Web_Intro.Context;
using Web_Intro.Entities;
using Web_Intro.Repositories.Abstracts;

namespace Web_Intro.Repositories;

public class CustomerRepository(EcommerceDbContext dbcontext) : ICustomerRepository
{
    private readonly EcommerceDbContext ecommerceDbContext = dbcontext;
    public void Add(Customer customer)
    {
        ecommerceDbContext.Add(customer);
        ecommerceDbContext.SaveChanges();
    }

    public void Delete(string customerid)
    {
        var customer = GetbyId(customerid);
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

    public IQueryable<Customer> GetAll()
    {
        return ecommerceDbContext.Customers;
    }
}
