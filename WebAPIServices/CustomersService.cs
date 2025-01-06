using WebAPIDatalayer.Models;
using WebAPIDatalayer.Repoitorys;
using WebAPIServices.Interface;

namespace WebAPIServices
{
    public class CustomersService : ICustomersService
    {
        private readonly IRepoitory<Customers> _customersRepoitory;
        public CustomersService(IRepoitory<Customers> customersRepoitory) {
            this._customersRepoitory = customersRepoitory;
        }

        public List<Customers> GetCustomers()
        {
            return _customersRepoitory.GetAll();
        }

        public Customers GetCustomersById(string id) 
        {
            return _customersRepoitory.Get(id);
        }

        public int InsertCustomers(Customers customer)
        {
            return _customersRepoitory.Insert(customer);
        }
        public int UpdateCustomers(Customers customer) 
        {
            return _customersRepoitory.Update(customer);
        }
        public int DeleteCustomers(string id)
        {
            return _customersRepoitory.Delete(id);
        }
    }
}
