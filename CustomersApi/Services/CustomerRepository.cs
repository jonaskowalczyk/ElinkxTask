using CustomersApi.DbContexts;
using CustomersApi.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersApi.Services
{
    public class CustomerRepository : ICustomerRepository
    {

        private CustomerContext customerContext { get; }

        public CustomerRepository(CustomerContext customerContext)
        {
            this.customerContext = customerContext;
        }

        public void AddCustomer(CustomerObject customerObject)
        {
            throw new NotImplementedException();
        }

        public bool CustomerExist(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(CustomerObject customerObject)
        {
            throw new NotImplementedException();
        }

        public CustomerObject GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public CustomerObject GetCustomers()
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(CustomerObject customerObject)
        {
            throw new NotImplementedException();
        }
    }
}
