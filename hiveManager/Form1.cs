namespace hiveManager
{
    public partial class Form1 : Form
    {
        Queen queen;
        private readonly string[] jobs =
        {
            "Nauczanie pszcz�ek",
            "Piel�gnacja jaj",
            "Utrzymanie ula",
            "Wytwarzanie miodu",
            "Zbieranie nektaru",
            "Patrol z ��d�ami"
        };

        public Form1()
        {
            InitializeComponent();
            cBox_workerJob.SelectedIndex = 0;
            cBox_workerJob.Items.Add(jobs);
            cBox_workerJob.Items.RemoveAt(cBox_workerJob.Items.Count - 1);
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { jobs[4], jobs[3] }, 175D);
            workers[1] = new Worker(new string[] { jobs[1], jobs[0] }, 114D);
            workers[2] = new Worker(new string[] { jobs[2], jobs[3] }, 149D);
            workers[3] = new Worker(jobs, 155D);
            queen = new Queen(workers, 275D);
/*            NectarStinger bobTheBee = new NectarStinger(null, 123D);
            bobTheBee.LookForEnemies();
            bobTheBee.FindFlowers();*/
        }

        private void b_assignWork_Click(object sender, EventArgs e)
        {
            if(queen.AssingWork(cBox_workerJob.Text, (int)nUD_shiftCount.Value) == false)
            {
                MessageBox.Show($"Nie ma dost�pnych robotnic do wykonania zadania '{cBox_workerJob.Text}'", "Kr�lowa pszcz� m�wi...");
            } else
            {
                MessageBox.Show($"Zadanie '{cBox_workerJob.Text}' b�dzie uko�czone za {nUD_shiftCount.Value} zmiany", "Kr�lowa pszcz� m�wi...");
            }
        }

        private void b_nextShift_Click(object sender, EventArgs e)
        {
            rTB_output.Text = queen.WorkTheNextShift();
        }
    }
}