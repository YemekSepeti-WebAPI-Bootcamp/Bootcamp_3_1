using Bootcamp_3_1.Ordering.Domain.Interfaces;
using System;

namespace Bootcamp_3_1.Ordering.Domain.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
    }
}