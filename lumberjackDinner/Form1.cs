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
            if (breakfastLine.Count == 0) return;
            Lumberjack nextLumberjack = breakfastLine.Dequeue();
            nextLumberjack.EatFlapjacks();
            l_status.Text = "";
            RedrawList();
        }

        private void RedrawList()
        {
            int number = 1;
            lB_queue.Items.Clear();
            foreach (Lumberjack lumberjack in breakfastLine)
            {
                lB_queue.Items.Add(number + ". " + lumberjack.Name);
                number++;
            }
            if (breakfastLine.Count == 0)
            {
                groupBox1.Enabled = false;
                l_status.Text = "";
            }
            else
            {
                groupBox1.Enabled = true;
                Lumberjack currentLumberjack = breakfastLine.Peek();
                l_status.Text = currentLumberjack.Name + " ma " + currentLumberjack.FlapjackCount + " naleœników";
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
    }
}