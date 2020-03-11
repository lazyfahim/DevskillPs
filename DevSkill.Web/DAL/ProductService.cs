using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ProductService : IProductService
    {
        private IList<Product> _products;
        private string _connectionString;

        public ProductService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public (IList<Product> products,int total, int totalDisplay) GetProducts(int pageIndex,
            int pageSize, string searchText = "", string sortText="")
        {
            using var dbProvider = new SqlDataProvider<Product>(_connectionString);
            string sql = "select * from product";
            if(searchText != null)
            {
                sql += $"where Id = {searchText} or Name = {searchText} or Description = {searchText} or Price = {searchText}";
            }
            sql += $"order by Id asc OFFSET {(pageSize)*(pageIndex-1)}" +
                $" rows fetch next {pageSize} rows only";
            this._products = dbProvider.GetData(sql);
            IEnumerable<Product> filteredProducts;
            if (searchText != null)
            {
                filteredProducts = _products.Where(x => x.Name.Contains(searchText,StringComparison.CurrentCultureIgnoreCase));
            }
            else
                filteredProducts = _products;
            var totalProducts = dbProvider.GetScalar();
            var totalFltrd = filteredProducts.Count();
            var filteredProductsList = filteredProducts.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return (filteredProductsList, totalProducts, totalFltrd);
        }
    }
}
