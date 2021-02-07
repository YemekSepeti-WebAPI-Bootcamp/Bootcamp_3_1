using Bootcamp_3_1.Ordering.Domain.Response.Customer;
using Bootcamp_3_1.Ordering.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Bootcamp_3_1.Ordering.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ILogger<CustomersController> _logger;
        private readonly ICustomerService _customerService;

        public CustomersController(ILogger<CustomersController> logger,
                                   ICustomerService customerService)
        {
            _logger = logger;
            _customerService = customerService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(CustomerResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var customers = await _customerService.GetCustomers();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(CustomerResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomerResponse), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(int id)
        {
            //var customer = await _customerService.GetCustomer(c => c.Id == id);
            var customer = await _customerService.GetCustomer(id);

            if (customer == null)
                return NotFound();

            return Ok(customer);
        }
    }
}