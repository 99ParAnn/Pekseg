using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekseg
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Bakery b1 = new Bakery("Potato");

			b1.AddProduct(new Muffin("mf1", 144,4,"Tasty"));
			b1.AddProduct(new Croissant("cr1", 55,155,10));
			b1.AddProduct(new Bagel("bg1", 330,33,"fghgf"));
			b1.AddProduct(new Croissant("cr2", 300,4,22));
			b1.DisplayProducts();

			Console.WriteLine($"Total price: {b1.CalculateTotalPrice()}");
			Console.WriteLine($"Total calories: {b1.CalculateTotalCalories()}");

            Console.WriteLine("\n\nIncreasing prices...");
            foreach (var item in b1.Products)
			{
				item.IncreasePrice(42);
			}

			b1.DisplayProducts();

			Console.WriteLine($"Total price: {b1.CalculateTotalPrice()}");
			Console.WriteLine($"Total calories: {b1.CalculateTotalCalories()}");


		}
	}
}
