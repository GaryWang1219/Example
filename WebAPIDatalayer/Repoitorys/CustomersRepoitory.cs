using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIDatalayer.Models;

namespace WebAPIDatalayer.Repoitorys
{
    public class CustomersRepoitory : IRepoitory<Customers>
    {
        private readonly IDbConnection _connection;
        public CustomersRepoitory(IDbConnection connection)
        {
            this._connection = connection;
        }

        public List<Customers> GetAll()
        {
            var result = new List<Customers>();

            using (var connection = _connection)
            {
                result = connection.Query<Customers>($@"SELECT [CustomerID]
                                                              ,[CompanyName]
                                                              ,[ContactName]
                                                              ,[ContactTitle]
                                                              ,[Address]
                                                              ,[City]
                                                              ,[Region]
                                                              ,[PostalCode]
                                                              ,[Country]
                                                              ,[Phone]
                                                              ,[Fax]
                                                         FROM [master].[dbo].[Customers]").ToList();
            }
            return result;
        }
        public Customers Get(string id)
        {
            var result = new Customers();
            result = _connection.Query<Customers>($@"SELECT [CustomerID]
                                                           ,[CompanyName]
                                                           ,[ContactName]
                                                           ,[ContactTitle]
                                                           ,[Address]
                                                           ,[City]
                                                           ,[Region]
                                                           ,[PostalCode]
                                                           ,[Country]
                                                           ,[Phone]
                                                           ,[Fax]
                                                       FROM [master].[dbo].[Customers]
                                                      WHERE [CustomerID] = @CustomerID", new { CustomerID = id }).FirstOrDefault();

            return result;
        }

        public int Insert(Customers customer)
        {
            var result = 0;
            result = _connection.Execute($@"INSERT INTO [dbo].[Customers]
                                                ([CustomerID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [Region], [PostalCode], [Country], [Phone],[Fax])
                                            VALUES
                                                (@CustomerID ,@CompanyName, @ContactName ,@ContactTitle ,@Address, nvarchar(60), @City ,@Region ,@PostalCode ,@Country ,@Phone ,@Fax)", customer);

            return result;
        }

        public int Update(Customers customer)
        {
            var result = 0;
            result = _connection.Execute($@"UPDATE [dbo].[Customers]
                                               SET [CompanyName] = @CompanyName
                                                  ,[ContactName] = @ContactName
                                                  ,[ContactTitle] = @ContactTitle
                                                  ,[Address] = @Address
                                                  ,[City] = @City
                                                  ,[Region] = @Region
                                                  ,[PostalCode] = @PostalCode
                                                  ,[Country] = @Country
                                                  ,[Phone] = @Phone
                                                  ,[Fax] = @Fax
                                             WHERE [CustomerID] = @CustomerID", customer);
            return result;
        }

        public int Delete(string id)
        {
            var result = 0;
            result = _connection.Execute($@"DELETE FROM [dbo].[Customers]
                                             WHERE [CustomerID] = @CustomerID", new { CustomerID = id });
            return result;
        }
    }
}
