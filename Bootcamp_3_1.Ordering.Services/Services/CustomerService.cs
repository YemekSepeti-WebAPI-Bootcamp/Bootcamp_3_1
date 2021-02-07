using Bootcamp_3_1.Ordering.Data.Repositories.Interface;
using Bootcamp_3_1.Ordering.Domain.Entities;
using Bootcamp_3_1.Ordering.Domain.Response.Customer;
using Bootcamp_3_1.Ordering.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Bootcamp_3_1.Ordering.Services.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<CustomerResponse> GetCustomer(int id)
        {
            var result = await _customerRepository.GetById(id);

            return new CustomerResponse
            {
                Id = result.Id,
                FullName = string.Concat(result.FirstName, result.LastName),
                BirthDate = result.BirthDate.Date,
                Phone = result.Phone
            };
        }

        public async Task<CustomerResponse> GetCustomer(Expression<Func<Customer, bool>> expression)
        {
            var result = await _customerRepository.Get(expression);

            // mapper

            return new CustomerResponse
            {
                Id = result.Id,
                FullName = string.Concat(result.FirstName, result.LastName),
                BirthDate = result.BirthDate.Date,
                Phone = result.Phone
            };
        }

        public async Task<List<CustomerResponse>> GetCustomers()
        {
            var result = await _customerRepository.GetAll();
            // mapper yazılacak.

            return result.Select(c => new CustomerResponse
            {
                Id = c.Id,
                FullName = string.Concat(c.FirstName, c.LastName),
                BirthDate = c.BirthDate.Date,
                Phone = c.Phone
            }).ToList();
        }
    }
}