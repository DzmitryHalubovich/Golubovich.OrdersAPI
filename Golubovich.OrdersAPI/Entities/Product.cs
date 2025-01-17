﻿namespace Golubovich.OrdersAPI.Entities
{
    //  Product Name
    //  Product Price
    //  Quantity
    //  Total Price
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice  => Price*=Quantity;
    }
}
