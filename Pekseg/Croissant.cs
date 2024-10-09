using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekseg
{
	internal class Croissant : BakedGood
	{
		private int butterContent;

		public Croissant(string name, double price, int calories, int butterContent) : base(name, price, calories)
		{
			this. butterContent = butterContent;
		}

		public override string GetDescription()
		{
			return $"Croissant ({this.name}), Price: {price}, Calories: {calories} kcal, butter content: {butterContent} gr";
		}

		public override void IncreasePrice(double amount)
		{
			this.price += 50;
		}

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
