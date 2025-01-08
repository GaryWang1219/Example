using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIDatalayer.Models;
using WebAPIServices.Common;

namespace WebAPIServices.Interface
{
    public interface ICustomersService
    {
        Result<List<Customers>> GetCustomers();
        Result<Customers> GetCustomersById(string id);
        Result<int> InsertCustomers(Customers customer);
        Result<int> UpdateCustomers(Customers customer);
        Result<int> DeleteCustomers(string id);
    }
}
