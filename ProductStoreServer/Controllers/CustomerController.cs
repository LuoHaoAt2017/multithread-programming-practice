using Microsoft.AspNetCore.Mvc;
using ProductStoreServer.Models;
using ProductStoreServer.Services;

namespace ProductStoreServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private CustomerService service = new CustomerService();

		// GET: api/<ProductController>
		[HttpGet]
        public List<Customer> Get()
        {
			var result = this.service.GetCustomerList();
			//List<Customer> result = new List<Customer>(2);
            //result.Add(new Customer("123", "Apple"));
            //result.Add(new Customer("456", "Banana"));
            return result;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
