using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partyPlanner2
{
    internal class DinnerParty : Party
    {
        public bool HealthyOption { get; set; }
        public override decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += ((CalculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson) * NumberOfPeople);
                if (HealthyOption)
                {
                    totalCost *= .95M;
                }
                return totalCost + (NumberOfPeople > 12 ? 100 : 0);
            }
        }

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption) : base(numberOfPeople, fancyDecorations)
        {
            HealthyOption = healthyOption;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            return (HealthyOption ? 5.00M : 20.00M);
        }
    }
}
