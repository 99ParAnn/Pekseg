using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekseg
{
	internal class Bagel : BakedGood
	{
		string topping;

		public Bagel(string name, double price, int calories, string topping) : base(name, price, calories)
		{
			this.topping = topping;
		}

		public override string GetDescription()
		{
			return $"Bagel ({this.name}), Price: {price}, Calories: {calories} kcal, topping: {topping}";

		}

		public override void IncreasePrice(double amount)
		{
			this.price += 30;
		}
	}
}
