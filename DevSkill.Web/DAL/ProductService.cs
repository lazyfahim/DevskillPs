using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ProductService
    {
        private IList<Product> _products;
        private string _connectionString;
        public ProductService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public (IList<Product> products,int total, int totalDisplay) GetProducts(int pageIndex,
            int pageSize,string searchText,string sortText)
        {
            using var dbProvider = new SqlDataProvider<Product>(_connectionString);
            this._products = dbProvider.GetData("select * from product");
            var filteredProducts = _products.Where(x => x.Name.Contains(searchText));
            var totalProducts = _products.Count();
            var totalFltrd = filteredProducts.Count();
            var filteredProductsList = filteredProducts.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return (filteredProductsList, totalProducts, totalFltrd);
        }
    }
}
