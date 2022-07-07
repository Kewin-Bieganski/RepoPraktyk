using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partyPlanner
{
    internal class DinnerParty
    {
        public const decimal costOfFoodPerPerson = 25;
        public decimal costOfBeveragesPerPerson;
        public decimal costOfDecorations;
        public int numerOfPeople = 0;

        public void SetHealthyOption(bool healthyOption)
        {
           costOfBeveragesPerPerson = (healthyOption ? 5.00M : 20.00M);
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            costOfDecorations = (fancy ? (numerOfPeople * 15.00M) + 50M : (numerOfPeople * 7.50M) + 30M);
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = costOfDecorations + ((costOfBeveragesPerPerson + costOfFoodPerPerson) * numerOfPeople);
            if(healthyOption)
            {
                return totalCost * .95M;
            }
            return totalCost;
        }


    }
}
