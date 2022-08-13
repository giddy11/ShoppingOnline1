using FluentNHibernate.Mapping;
using ShopOnline.Domain.Models;

namespace ShopOnline.DB.Mappings
{
    public class ProductCategoryMap : ClassMap<ProductCategory>
    {
        public ProductCategoryMap()
        {
            Table("ProductCategory");
            Id(pCategory => pCategory.ID).GeneratedBy.Guid();
            Map(pCategory => pCategory.Name);
            HasMany(pCategory => pCategory.Products);
        }
    }
}
