using Bootcamp_3_1.Ordering.Domain.Entities;
using Bootcamp_3_1.Ordering.Domain.Response.Customer;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Bootcamp_3_1.Ordering.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<List<CustomerResponse>> GetCustomers();

        Task<CustomerResponse> GetCustomer(Expression<Func<Customer, bool>> expression);
        Task<CustomerResponse> GetCustomer(int id);

    }
}