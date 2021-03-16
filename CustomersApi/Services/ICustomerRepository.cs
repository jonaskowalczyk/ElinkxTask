using CustomersApi.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersApi.Services
{
    public interface ICustomerRepository
    {
        public CustomerObject GetCustomers();
        public CustomerObject GetCustomer(int id);
        public void AddCustomer(CustomerObject customerObject);
        public void UpdateCustomer(CustomerObject customerObject);
        public void DeleteCustomer(CustomerObject customerObject);
        public bool CustomerExist(int id);
        public bool Save();

    }
}
