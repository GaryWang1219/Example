using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebAPIDatalayer.Models;
using WebAPIServices.Common;
using WebAPIServices.Interface;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomersService _customersService;
        public CustomerController(ICustomersService customersService) 
        {
            this._customersService = customersService;
        }

        [HttpGet]
        [Route("customers")]
        public string GetAllCustomers()
        {
            var result = this._customersService.GetCustomers();
            return JsonConvert.SerializeObject(result);
        }

        [HttpGet]
        [Route("customers/{id}")]
        public string GetCustomer([FromRoute]string id)
        {
            var result = _customersService.GetCustomersById(id);
            return JsonConvert.SerializeObject(result);
        }

        [HttpPost]
        [Route("customers")]
        public string InsertCustomer(Customers customer)
        {
            var result = _customersService.InsertCustomers(customer);
            return JsonConvert.SerializeObject(result);
        }

        [HttpPut]
        [Route("customers")]
        public string UpdateCustomer(Customers customer)
        {
            var result = _customersService.UpdateCustomers(customer);
            return JsonConvert.SerializeObject(result);
        }

        [HttpDelete]
        [Route("customers/{id}")]
        public string DeleteCustomer([FromRoute] string id)
        {
            var result = _customersService.DeleteCustomers(id);
            return JsonConvert.SerializeObject(result);
        }
    }
}
