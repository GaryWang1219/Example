using WebAPIDatalayer.Models;
using WebAPIDatalayer.Repoitorys;
using WebAPIServices.Common;
using WebAPIServices.Interface;

namespace WebAPIServices
{
    public class CustomersService : ICustomersService
    {
        private readonly IRepoitory<Customers> _customersRepoitory;
        public CustomersService(IRepoitory<Customers> customersRepoitory)
        {
            this._customersRepoitory = customersRepoitory;
        }

        public Result<List<Customers>> GetCustomers()
        {
            try
            {
                var data = _customersRepoitory.GetAll();
                return new Result<List<Customers>>()
                {
                    Success = true,
                    Code = (int)ErrorCode.Success,
                    Content = data
                };

            }
            catch (Exception ex)
            {
                return new Result<List<Customers>>()
                {
                    Success = false,
                    Code = (int)ErrorCode.UnknownError,
                    Message = ex.Message
                };
            }

        }

        public Result<Customers> GetCustomersById(string id)
        {
            try
            {
                var data = _customersRepoitory.Get(id);

                return new Result<Customers>()
                {
                    Success = true,
                    Code = (int)ErrorCode.Success,
                    Content = data
                };
            }
            catch (Exception ex)
            {
                return new Result<Customers>()
                {
                    Success = false,
                    Code = (int)ErrorCode.UnknownError,
                    Message = ex.Message
                };
            }
        }

        public Result<int> InsertCustomers(Customers customer)
        {
            try
            {
                var result = _customersRepoitory.Insert(customer);

                return new Result<int>()
                {
                    Success = true,
                    Code = (int)ErrorCode.Success,
                    Content = result
                };
            }
            catch (Exception ex)
            {
                return new Result<int>()
                {
                    Success = false,
                    Code = (int)ErrorCode.UnknownError,
                    Message = ex.Message
                };
            }
        }

        public Result<int> UpdateCustomers(Customers customer)
        {
            try
            {
                var result = _customersRepoitory.Update(customer);

                return new Result<int>()
                {
                    Success = true,
                    Code = (int)ErrorCode.Success,
                    Content = result
                };
            }
            catch (Exception ex)
            {
                return new Result<int>()
                {
                    Success = false,
                    Code = (int)ErrorCode.UnknownError,
                    Message = ex.Message
                };
            }
        }

        public Result<int> DeleteCustomers(string id)
        {
            try
            {
                var result = _customersRepoitory.Delete(id);

                return new Result<int>()
                {
                    Success = true,
                    Code = (int)ErrorCode.Success,
                    Content = result
                };
            }
            catch (Exception ex)
            {
                return new Result<int>()
                {
                    Success = false,
                    Code = (int)ErrorCode.UnknownError,
                    Message = ex.Message
                };
            }
        }
    }
}
