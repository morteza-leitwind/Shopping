namespace OnlineShop.Models
{
	public class Cart
	{
		public virtual int Id { get; set; }
		public virtual decimal Price { get; set; }
		public virtual string Name { get; set; }
		public virtual string Picture { get; set; }
		public virtual int Quantity { get; set; }
		public virtual int ProductId { get; set; }
	}
}