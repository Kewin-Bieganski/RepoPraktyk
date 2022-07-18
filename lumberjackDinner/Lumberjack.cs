using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lumberjackDinner
{
    internal class Lumberjack
    {
        private string name;
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;
        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }
        public int FlapjackCount { get { return 0; } }
        public void TakeFlapjacks(Flapjack food, int HowMany)
        {
            
        }
        public void EatFlapjacks()
        {
            
        }
    }
}
