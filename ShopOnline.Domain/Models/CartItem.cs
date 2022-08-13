namespace ShopOnline.Domain.Models
{
    public class CartItem : BaseEntity
    {
        //public CartItem()
        //{
        //    ID = Guid.NewGuid();
        //}
        public virtual int CartId { get; set; }
        public virtual int ProductId { get; set; }
        public virtual int Quantity { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}