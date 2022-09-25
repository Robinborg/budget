using System;

namespace Costs
{
	public class Cost
	{
		public double rent {get; set;}
		public double food {get; set;}
	  public double utilities {get; set;}
		public double exercise {get; set;}
		public double householdItems {get; set;}
		public double entertainment {get; set;}

		public void showAllCosts()
		{
			Console.WriteLine("Rent: {0}", rent);
			Console.WriteLine("Food: {0}", food);
			Console.WriteLine("Utilities: {0}", utilities);
			Console.WriteLine("Exercise: {0}", exercise);
			Console.WriteLine("Household Items: {0}", householdItems);
			Console.WriteLine("Entertainment: {0}", entertainment);
		}
		public double summedCosts()
		{
			return rent + food + utilities + exercise + householdItems + entertainment;
		}
		public void showTotal()
		{
			double total = rent + food + utilities + exercise + householdItems +entertainment;
			Console.WriteLine("All costs: {0}", total);
		}
	}
}
