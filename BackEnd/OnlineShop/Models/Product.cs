﻿namespace OnlineShop.Models
{
	public class Product
	{
		public virtual int Id { get; set; }
		public virtual decimal Price { get; set; }
		public virtual string Name { get; set; }
		public virtual string Picture { get; set; }
	}
}