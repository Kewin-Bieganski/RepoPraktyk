namespace classFun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_talk_Click(object sender, EventArgs e)
        {
            int len = Talker.BlahBlahBlah(tB_text.Text, (int)nUD_times.Value);
            MessageBox.Show($"D�ugo�� wiadomo�ci to {len}.");
        }
    }
}