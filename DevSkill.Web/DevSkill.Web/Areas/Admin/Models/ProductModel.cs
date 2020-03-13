using DAL;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevSkill.Web.Areas.Admin.Models
{
    public class ProductModel
    {
        private readonly IProductService _productService;
        public ProductModel(IConfiguration configuration)
        {
            _productService = new ProductService(configuration.GetConnectionString("DefaultConnection"));
        }

        public object GetProducts(string searchText,int draw,int start,int length,string sorttext)
        {
            var data = _productService.GetProducts(start, length,searchText,sorttext);
            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from product in data.products
                        select new string[]
                        {
                            product.Id.ToString(),
                            product.Name,
                            product.Description,
                            product.Price.ToString()
                        }
                        )
            };
        }
    }
}
