using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIDatalayer.Repoitorys
{
    public interface IRepoitory<T> where T : class
    {
        List<T> GetAll();
        T Get(string id);

        int Insert(T item);
        int Update(T item);
        int Delete(string id);
    }
}
