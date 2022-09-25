using System;

namespace Costs
{
	public interface ICost
	{
		public double rent {get; set;}
    public double food {get; set;}
		public double utilities {get; set;}
		public double exercise {get; set;}
		public double householdItems {get; set;}
		public double entertainment {get; set;}

		void showAllCosts();
		double summedCosts();
		void showTotal();
	}
}
