using System;
using Costs;

namespace Budgets
{
	public class Budget
	{
		public double dailyCosts {get; set;}
		public double dailyEarnings {get; set;}

		public double monthlyCosts {get; set;}
		public double monthlyEarnings {get; set;}

		public int daysInMonth {get; set;}

		public ICost cost;
		public Budget(ICost cost)
		{
			this.cost = cost;
		}

		public double costOverDays(double cost, int daysSplitOver)
		{
			return cost / daysSplitOver;
		}
		public double calculateCostsMonth(int daysInMonth)
		{
			return this.dailyCosts * this.daysInMonth;
		}
		public double calculateCostsPerDay() 
		{
			double getMonthlyCosts = this.monthlyCosts;
			return getMonthlyCosts / daysInMonth;
		}
		public double addCosts(double[] paramCosts, string typeOfCost)
		{
			double total = paramCosts.Sum();
			if (typeOfCost.ToLower() == "rent")
				this.cost.rent = total;
			else if (typeOfCost.ToLower() == "food")
				this.cost.food = total;
			else if (typeOfCost.ToLower() == "utilities")
				this.cost.utilities = total;
			else if (typeOfCost.ToLower() == "exercise")
				this.cost.exercise = total;
			else if (typeOfCost.ToLower() == "householditems")
				this.cost.householdItems = total;
			else if (typeOfCost.ToLower() == "entertainment")
				this.cost.entertainment = total;
		  else return 0;
			return total;
		}
		public double addCosts(double costs, string typeOfCost)
		{
			if (typeOfCost.ToLower() == "rent")
				this.cost.rent = costs;
			else if (typeOfCost.ToLower() == "food")
				this.cost.food = costs;
			else if (typeOfCost.ToLower() == "utilities")
				this.cost.utilities = costs;
			else if (typeOfCost.ToLower() == "exercise")
				this.cost.exercise = costs;
			else if (typeOfCost.ToLower() == "householditems")
				this.cost.householdItems = costs;
			else if (typeOfCost.ToLower() == "entertainment")
				this.cost.entertainment = costs;
			else return 0;
			return costs;
		}
		public double addEarnings(params double[] paramEarnings)
		{
			double total = paramEarnings.Sum();
			return total;
		}
		public double calculateAvgCost(double[] cost)
		{
			return cost.Sum() / cost.Count();
		}
		public double getRemainingBalance()
		{
			return this.monthlyEarnings - this.monthlyCosts;
		}
	}
}
