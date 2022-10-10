using Core.Entities;

namespace Core.Spesifications
{
    public class ProductsWithFiltersForCountSpesification:BaseSpesification<Product>
    {
        public ProductsWithFiltersForCountSpesification(ProductSpecParams productParams)
        :base(x=>
        (string.IsNullOrEmpty(productParams.Search)||x.Name.ToLower().Contains(productParams.Search))&&
        (!productParams.BrandId.HasValue||x.ProductBrandId==productParams.BrandId)&&
        (!productParams.TypeId.HasValue||x.ProductTypeId==productParams.TypeId)
        )
        {

        }
    }
}