using System;

namespace Budgets
{
	class Program
	{
	  public static void Main(string[] args)
	  {
			Budget budget = new Budget();
			budget.monthlyEarnings = 1350;
			budget.daysInMonth = 30;
			budget.addCosts(650.00, "rent");
			budget.addCosts(400, "Food");
			budget.addCosts(10.00, "Entertainment");
			budget.addCosts(150.00, "Utilities");
			budget.addCosts(65.00, "Exercise");
			budget.addCosts(30.00, "householditems");
			budget.cost.showAllCosts();
			budget.cost.showTotal();
			budget.monthlyCosts = budget.cost.summedCosts();
			Console.WriteLine(budget.getRemainingBalance());

			//double avgCost = budget.calculateAvgCost(costsPerDay);
			//budget.dailyCosts = avgCost;
			//Console.WriteLine(budget.dailyCosts);
			//double monthlyCost = budget.calculateCostsMonth(budget.daysInMonth);
			//Console.WriteLine(monthlyCost);
	  }
	}
}
