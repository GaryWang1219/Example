using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebAPI.Common;
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

            return JsonConvert.SerializeObject(new ResponseParameter()
            { 
                Success = true,
                Code = "200",
                Content = result
            });
        }

        [HttpGet]
        [Route("customers/{id}")]
        public string GetCustomer(int id)
        {
            return JsonConvert.SerializeObject(new ResponseParameter()
            {
                Success = true,
                Code = "200",
                Content = new { }
            });
        }

        [HttpPost]
        [Route("customers")]
        public string InsertCustomer()
        {
            return JsonConvert.SerializeObject(new ResponseParameter()
            {
                Success = true,
                Code = "200",
                Content = new { }
            });
        }

        [HttpPut]
        [Route("customers/{id}")]
        public string UpdateCustomer(int id)
        {
            return JsonConvert.SerializeObject(new ResponseParameter()
            {
                Success = true,
                Code = "200",
                Content = new { }
            });
        }

        [HttpDelete]
        [Route("customers/{id}")]
        public string DeleteCustomer(int id)
        {
            return JsonConvert.SerializeObject(new ResponseParameter()
            {
                Success = true,
                Code = "200",
                Content = new { }
            });
        }
    }
}
