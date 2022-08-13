namespace ShopOnline.Domain.Models
{
    public class User : BaseEntity
    {
        //public User()
        //{
        //    ID = Guid.NewGuid();
        //}
        public virtual string UserName { get; set; }
        public virtual Cart Cart { get; set; }
    }
}