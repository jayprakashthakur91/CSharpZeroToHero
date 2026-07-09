using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Zero_to_Hero.Chapter19._6
{
    class Product
    {
       private double price;
       public double Price
            { get { return price; } set 
            { 
                if (value < 0)
                        Console.Write("Price cannot be negative.");
                price = value; } }
       public required string Name { get; set; }
       public double DiscountedPrice => Price * 0.9;
    }
    class Program
    {
        //static void Main(string[] args)
        //{
            
        //    Product product = new Product { Name = "Laptop" };
        //    product.Price = 1000;
        //    Console.WriteLine($"Product: {product.Name}, Price: {product.Price}, Discounted Price: {product.DiscountedPrice}");
        //}
    }
 
}
