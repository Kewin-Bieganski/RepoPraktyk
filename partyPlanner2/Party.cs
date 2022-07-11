namespace partyPlanner2
{
    internal class Party
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public virtual decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                return (totalCost + (NumberOfPeople > 12 ? 100 : 0));
            }
        }

        public Party(int numberOfPeople, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
        }

        protected decimal CalculateCostOfDecorations()
        {
            return (FancyDecorations ? (NumberOfPeople * 15.00M) + 50M : (NumberOfPeople * 7.50M) + 30M);
        }
    }
}
