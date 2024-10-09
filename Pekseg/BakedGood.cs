using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekseg
{
	abstract class BakedGood
	{

		protected string name;
		protected double price;
		protected int calories;

		protected string Name { get => name;}
		public double Price { get => price; }
		public int Calories { get => calories; }

		public BakedGood(string name, double price, int calories)
		{
			this.name = name;
			this.price = price;
			this.calories = calories;
		}

		public abstract string GetDescription();
		public abstract void IncreasePrice(double amount);
	}
}
