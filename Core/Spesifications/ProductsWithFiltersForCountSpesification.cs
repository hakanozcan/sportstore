using Core.Entities;

namespace Core.Spesifications
{
    public class ProductsWithFiltersForCountSpesification:BaseSpesification<Product>
    {
        public ProductsWithFiltersForCountSpesification(ProductSpecParams productParams)
        :base(x=>
        (!productParams.BrandId.HasValue||x.ProductBrandId==productParams.BrandId)&&
        (!productParams.TypeId.HasValue||x.ProductTypeId==productParams.TypeId)
        )
        {

        }
    }
}