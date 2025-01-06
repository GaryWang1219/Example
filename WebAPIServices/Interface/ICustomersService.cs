using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIDatalayer.Models;

namespace WebAPIServices.Interface
{
    public interface ICustomersService
    {
        List<Customers> GetCustomers();
        Customers GetCustomersById(string id);
        int InsertCustomers(Customers customer);
        int UpdateCustomers(Customers customer);
        int DeleteCustomers(string id);
    }
}
