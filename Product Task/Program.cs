using Product_Task.Models;
using System;

namespace Product_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Corek",0.65,Enum.ProductType.Bakery);
            Console.WriteLine(product);
        }
    }
}
