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

        public readonly List<Product> productList;
        public readonly List<Customer> customerList;

        public LinqSampleBase()
        {
            _repo = new Repository();
            productList = _repo.GetProducts();
            customerList = _repo.GetCustomers();
        }
    }
}
