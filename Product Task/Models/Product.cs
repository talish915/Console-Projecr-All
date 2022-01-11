using Product_Task.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Task.Models
{
    class Product
    {
        private static int _count = 1000;
        public string  Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountedPrice { get; set; }
        public ProductType Type { get; set; }
        public static int TotalCount { get; set; }

        public Product(string name, double price, ProductType type)
        {
            Name = name;
            Type = type;
            _count++;
            Price = price;

            switch ((int)Type)
            {
                case 0:
                    Code += "B" + _count;
                    DiscountedPrice = price - (price * 10 / 100);
                    break;
                case 1:
                    Code += "D" + _count;
                    break;
                case 2:
                    Code += "M" + _count;
                    break;
                case 3:
                    Code += "F" + _count;
                    break;
            }
        }
        public override string ToString()
        {
            return $"Kodu: {Code}\nQiymeti: {Price}\nEndirimli Qiymeti: {DiscountedPrice}\nMalin Novu: {Type}";
        }
    }
}
