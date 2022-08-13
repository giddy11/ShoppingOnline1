namespace ShopOnline.Domain.Models
{
    public class Product : BaseEntity
    {
        //public Product()
        //{
        //    ID = Guid.NewGuid();
        //}

        public virtual int CategoryId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string ImageUrl { get; set; }
        public virtual decimal ProductPrice { get; set; }
        public virtual int Quantity { get; set; }
    }
}