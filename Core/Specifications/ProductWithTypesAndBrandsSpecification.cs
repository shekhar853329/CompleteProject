using Core.Entities;

namespace Core.Specifications
{
    public class ProductWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductWithTypesAndBrandsSpecification(int id) : base(x => x.Id == id)
        {
            AddInclude(x=>x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
        public ProductWithTypesAndBrandsSpecification()
        {
            AddInclude(x=>x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
    }
}