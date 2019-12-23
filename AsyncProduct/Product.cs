using System;

namespace AsyncProduct
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Provider { get; set; }
        public DateTime BeginDate { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
    }
}