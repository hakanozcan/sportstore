using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Spesifications
{
    public class ProductsWithTypesAndBrandsSpesification : BaseSpesification<Product>
    {
        public ProductsWithTypesAndBrandsSpesification()
        {
            AddInclude(x=>x.ProductType);
            AddInclude(x=>x.ProductBrand);
        }

        public ProductsWithTypesAndBrandsSpesification(int id) : base(x=>x.Id==id)
        {
             AddInclude(x=>x.ProductType);
             AddInclude(x=>x.ProductBrand);
        }
    }
}