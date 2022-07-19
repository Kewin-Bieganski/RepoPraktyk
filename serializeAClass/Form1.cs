using System.Runtime.Serialization.Formatters.Binary;

namespace serializeAClass
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;
        string fullPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Plik_faceta.dat";

        public Form1()
        {
            InitializeComponent();
            bob = new Guy()
            {
                name = "Bob",
                cash = 100,
            };

            joe = new Guy() { name = "Joe", cash = 50 };
            /*            joe.name = "Joe";
                        joe.cash = 50;*/

            UpdateForm();
        }

        private void b_giveToJoe_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bank nie posiada takiej iloœci pieniêdzy.", "Bank zbankrutowa³.");
            }
        }

        private void b_receiveFromBob_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        public void UpdateForm()
        {
            l_joeCash.Text = $"{joe.name} ma {joe.cash} z³.";
            l_bobCash.Text = $"{bob.name} ma {bob.cash} z³.";
            l_bankCash.Text = $"Bank ma {bank} z³.";
        }

        private void b_joeToBob_Click(object sender, EventArgs e)
        {
            bob.ReceiveCash(joe.GiveCash(10));
            UpdateForm();
        }

        private void b_bobToJoe_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash(bob.GiveCash(5));
            UpdateForm();
        }

        private void b_saveJoe_Click(object sender, EventArgs e)
        {
            using(Stream output = File.Create(fullPath))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, joe);
            }
        }

        private void b_readJoe_Click(object sender, EventArgs e)
        {
            using(Stream input = File.OpenRead(fullPath))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                joe = (Guy)formatter.Deserialize(input);
            }
            UpdateForm();
        }
    }
}