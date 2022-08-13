using FluentNHibernate.Mapping;
using ShopOnline.Domain.Models;

namespace ShopOnline.DB.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("User");
            Id(user => user.ID).GeneratedBy.Guid();
            Map(user => user.UserName);
            HasOne(user => user.Cart);
        }
    }
}
