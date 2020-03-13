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
            int pageSize, string searchText = "null", string sortText="null")
        {
            if (sortText == null)
                sortText = "Id";
            using var dbProvider = new SqlDataProvider<Product>(_connectionString);
            string sql = $"declare @cnt int; exec [spGetProduct] {pageIndex}, {pageSize},'{sortText}','{searchText}', @cnt output;" +
                         $"select @cnt as cnt";
            int  totalFltrd = 0;

            (this._products,totalFltrd) = dbProvider.GetData(sql);
            IEnumerable<Product> filteredProducts = searchText != null ? _products.Where(x => x.Name.Contains(searchText,StringComparison.CurrentCultureIgnoreCase)) : _products;
            var totalProducts = dbProvider.GetTotal("Product");
            return (_products, totalProducts, totalFltrd);
        }
    }
}
