namespace ClothingShop.Domain.Common
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
        }

        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
