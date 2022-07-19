using System.Diagnostics;
using System.Text;

namespace eureka
{
    public partial class Form1 : Form
    {
        private string fullPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\eureka.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void b_1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(fullPath, "Eureka!\uFAFA");
            byte[] eurekaBytes = File.ReadAllBytes(fullPath);
            foreach(byte b in eurekaBytes)
            {
                Debug.Write($"{b} ");
            }
            Debug.Write(Environment.NewLine);
        }

        private void b_2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(fullPath, "Eureka!");
            byte[] eurekaBytes = File.ReadAllBytes(fullPath);
            foreach (byte b in eurekaBytes)
            {
                Debug.Write($"{b:x2} ");
            }
            Debug.Write(Environment.NewLine);
        }

        private void b_3_Click(object sender, EventArgs e)
        {
            File.WriteAllText(fullPath, "שלום", Encoding.Unicode);
            byte[] eurekaBytes = File.ReadAllBytes(fullPath);
            foreach (byte b in eurekaBytes)
            {
                Debug.Write($"{b:x2} ");
            }
            Debug.Write(Environment.NewLine);
        }

        private void b_4_Click(object sender, EventArgs e)
        {
            byte[] data;
            File.WriteAllText(fullPath, "Witaj!!");
            data = File.ReadAllBytes(fullPath);
            Array.Reverse(data);
            File.WriteAllBytes(fullPath, data);
        }
    }
}