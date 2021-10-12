using ProxyRepository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyRepository.Data
{
    public interface IRepository
    {
        IList<Customer> GetAll();
        void Save(Customer customer);
    }
}
