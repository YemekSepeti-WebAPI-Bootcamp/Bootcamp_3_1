using System;

namespace Bootcamp_3_1.Ordering.Domain.Response.Customer
{
    public class CustomerResponse
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
    }
}