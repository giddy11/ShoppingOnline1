using FluentNHibernate.Mapping;
using ShopOnline.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.DB.Mappings
{
    public class CartMap : ClassMap<Cart>
    {
        public CartMap()
        {
            Table("Cart");
            Id(cart => cart.ID).GeneratedBy.Guid();
            References(cart => cart.UserId);
            HasMany(cart => cart.CartItems);
        }
    }
}
