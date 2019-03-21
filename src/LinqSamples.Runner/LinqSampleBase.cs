using LinqSamples.Data.Model;
using LinqSamples.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinqSamples.Runner
{
    public class LinqSampleBase
    {
        private readonly Repository _repo;

        private List<Product> productList;
        private List<Customer> customerList;
        private List<Supplier> supplierList;

        public LinqSampleBase()
        {
            _repo = new Repository();
        }

        public List<Product> GetProductList()
        {
            if (productList == null)
                productList = _repo.GetProducts();

            return productList;
        }

        public List<Customer> GetCustomerList()
        {
            if (customerList == null)
                customerList = _repo.GetCustomers();

            return customerList;
        }

        public List<Supplier> GetSupplierList()
        {
            if (supplierList == null)
                supplierList = _repo.GetSuppliers();

            return supplierList;
        }
    }
}
