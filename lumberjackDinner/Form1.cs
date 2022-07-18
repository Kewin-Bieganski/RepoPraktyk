namespace lumberjackDinner
{
    public partial class Form1 : Form
    {
        private Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();

        public Form1()
        {
            InitializeComponent();
        }

        private void b_addLumberjack_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tB_name.Text)) return;
            breakfastLine.Enqueue(new Lumberjack(tB_name.Text));
            tB_name.Text = "";
            RedrawList();
        }

        private void b_addFlapjacks_Click(object sender, EventArgs e)
        {
            Flapjack food;
            if (rB_crispy.Checked == true)
                food = Flapjack.Chrupkiego;
            else if (rB_soggy.Checked == true)
                food = Flapjack.Wilgotnego;
            else if (rB_ruddy.Checked == true)
                food = Flapjack.Rumianego;
            else
                food = Flapjack.Bananowego;
            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)nUD_count.Value);
            RedrawList();
        }

        private void b_nextLumberjack_Click(object sender, EventArgs e)
        {

        }

        

        private void RedrawList()
        {
            int number = 1;
            line.Items.Clear();
            foreach (Lumberjack lumberjack in breakfastLine)
            {
                line.Items.Add(number + ". " + lumberjack.Name);
                number++;
            }
            if (breakfastLine.Count == 0)
            {
                groupBox1.Enabled = false;
                nextInLine.Text = "";
            }
            else
            {
                groupBox1.Enabled = true;
                Lumberjack currentLumberjack = breakfastLine.Peek();
 }
        }
        private void nextLumberjack_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count == 0) return;
            Lumberjack nextLumberjack = breakfastLine.Dequeue();
            nextLumberjack.EatFlapjacks();
            l_status.Text = "";
            RedrawList();
        }
        class Lumberjack
        {
            private string name;
            public string Name { get { return name; } }
            private Stack<Flapjack> meal;
            public Lumberjack(string name)
            {
                this.name = name;
                meal = new Stack<Flapjack>();
            }
            public int FlapjackCount { get { return meal.Count; } }
            public void TakeFlapjacks(Flapjack food, int HowMany)
            {
                for (int i = 0; i < HowMany; i++)
                {
                    meal.Push(food);
                }
            }
            public void EatFlapjacks()
            {
            }
        }
    }
}