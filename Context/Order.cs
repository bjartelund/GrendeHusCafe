using System;
using System.Collections.Generic;

namespace Context
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } = "Cart";
        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
    }
}