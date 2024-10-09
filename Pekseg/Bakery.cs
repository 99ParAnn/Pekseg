using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekseg
{
	internal class Bakery
	{
		private string name;
		private List<BakedGood> products;

		public Bakery(string name)
		{
			this.name = name;
			this.products = new List<BakedGood>();
		}

		internal List<BakedGood> Products { get => products; set => products = value; }

		public void AddProduct(BakedGood toAdd)
		{
			products.Add(toAdd);
		}
		public int CalculateTotalCalories()
		{
			int total = 0;
			foreach (var item in products)
			{
				total += item.Calories;
			}
			return total;
		}
		public double CalculateTotalPrice()
		{
			double total = 0;
			foreach (var item in products)
			{
				total += item.Price;
			}
			return total;
		}

		public void DisplayProducts()
		{
            Console.WriteLine($"{this.name} Bakery \nProducts:");
			foreach (var item in products)
			{
				Console.WriteLine(item.GetDescription());
			}
        }



		/*- Bakery(string name): Konstruktor, amely inicializálja a pékség nevét.

- AddProduct(BakedGood product): Hozzáad egy péksüteményt a kínálathoz.

- DisplayProducts(): Kiírja a pékség összes péksüteményét.

- CalculateTotalCalories(): Visszaadja az összes péksütemény kalóriatartalmát.

- CalculateTotalPrice(): Visszaadja az összes péksütemény árát.*/
	}
}
