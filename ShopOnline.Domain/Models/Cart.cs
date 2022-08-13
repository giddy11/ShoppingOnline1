namespace ShopOnline.Domain.Models
{
    public class Cart : BaseEntity
    {
        //public Cart()
        //{
        //    ID = Guid.NewGuid();
        //}
        public virtual User UserId { get; set; }
        public virtual List<CartItem> CartItems { get; set; }
    }
}