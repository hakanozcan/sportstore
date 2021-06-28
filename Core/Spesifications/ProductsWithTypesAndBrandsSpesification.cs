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
    }
}