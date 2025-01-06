using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebAPI.Common;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public CustomerController() { }

        [HttpGet]
        [Route("customers")]
        public string GetAllCustomers()
        {


            return JsonConvert.SerializeObject(new ResponseParameter()
            { 
                Success = true,
                Code = "200",
                Content = new { }
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
