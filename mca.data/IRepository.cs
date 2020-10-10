using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace mca.data
{
    public interface IRepository<T>
    {
        Task<bool> Create(T obj);
        Task<bool> Update(T obj);
        Task<T> GetDetails(int key);
        Task<List<T>> GetAll();
        Task<bool> Delete(int key);
    }
}
