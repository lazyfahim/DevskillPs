using Models;
using System.Collections.Generic;

namespace DAL
{
    public interface IProductService
    {
        public (IList<Product> products, int total, int totalDisplay) GetProducts(int pageIndex,
            int pageSize, string searchText="", string sortText="");
    }
}