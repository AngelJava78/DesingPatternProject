using ProxyRepository.Data;
using ProxyRepository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyRepository.Proxy
{
    public class CustomerRepositoryProxy : IRepository
    {
        IRepository realRepository;

        public IList<Customer> GetAll()
        {
            var result = new List<Customer>();
            if(realRepository == null)
            {
                realRepository = new CustomerRepository();
            }
            if(Session.CanGetAll)
            {
                result=  realRepository.GetAll().ToList();
            }
            else
            {
                throw new UnauthorizedAccessException();
            }
            return result;
        }

        public void Save(Customer customer)
        {
            if(realRepository == null)
            {
                realRepository = new CustomerRepository();
            }
            if(Session.CanSave)
            {
                realRepository.Save(customer);
            }
            else
            {
                throw new UnauthorizedAccessException();
            }
        }
    }
}
