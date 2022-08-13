namespace ShopOnline.Domain.Models
{
    public class ProductCategory : BaseEntity
    {
        //public ProductCategory()
        //{
        //    ID = Guid.NewGuid();
        //}
        public virtual string Name { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}