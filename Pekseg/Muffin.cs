using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekseg
{
	internal class Muffin : BakedGood
	{
		private string flavor;
		public Muffin(string name, double price, int calories, string flavor) : base(name, price, calories)
		{
			this.flavor = flavor;
		}

		public override string GetDescription()
		{
			return $"Muffin ({this.name}), Price: {price}, Calories: {calories} kcal, flavor: {flavor}";
		}

		public override void IncreasePrice(double amount)
		{
			price *= 1.1;
		}
	}
	
	}

