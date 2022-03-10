﻿using Packt.Shared;

namespace Northwind.BlazorServer.Data
{
    public interface INorthwindService
    {
        Task<List<Customer>> GetCustomersAsync();
        Task<List<Customer>> GetCustomersAsync(string country);
        Task<Customer?> GetCustomerAsync(string id);
        Task<Customer> CreateCustomerAsync(Customer customer);
        Task<Customer> UpdateCustomerAsync(Customer customer);
        Task DeleteCustomerAsync(string id);
    }
}
