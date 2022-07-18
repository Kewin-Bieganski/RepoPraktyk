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
        private Stack<Flapjack> meal;
        public string Name { get { return name; } }
        public int FlapjackCount { get { return meal.Count; } }
        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }

        public void TakeFlapjacks(Flapjack food, int HowMany)
        {
            for (int i = 0; i < HowMany; i++)
            {
                meal.Push(food);
            }
        }

        public void EatFlapjacks()
        {
            Console.WriteLine(name + " je naleśniki");
            while(meal.Count > 0)
            {
                Console.WriteLine(name + " zjadł " + meal.Pop().ToString().ToLower() + " naleśnika");
            }
        }
    }
}
