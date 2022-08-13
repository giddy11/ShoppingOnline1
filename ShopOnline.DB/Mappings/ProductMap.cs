using FluentNHibernate.Mapping;
using ShopOnline.Domain.Models;

namespace ShopOnline.DB.Mappings
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Table("Product");
            Id(product => product.ID).GeneratedBy.Guid();
            Map(product => product.CategoryId);
            Map(product => product.Name);
            Map(product => product.Description);
            Map(product => product.ImageUrl);
            Map(product => product.ProductPrice);
            Map(product => product.Quantity);

        }
    }
}
