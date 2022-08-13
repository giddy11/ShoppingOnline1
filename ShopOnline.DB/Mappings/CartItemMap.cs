using FluentNHibernate.Mapping;
using ShopOnline.Domain.Models;

namespace ShopOnline.DB.Mappings
{
    public class CartItemMap : ClassMap<CartItem>
    {
        public CartItemMap()
        {
            Table("CartItem");
            Id(cartItem => cartItem.ID).GeneratedBy.Guid();
            Map(CartItem => CartItem.CartId);
            Map(CartItem => CartItem.ProductId);
            Map(CartItem => CartItem.Quantity);
            References(cartItem => cartItem.Cart);
            HasMany(cartItem => cartItem.Products);
        }
    }
}
