namespace dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //@"c:\M�jFolder\Domy�lne\";
            oPD_dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            oPD_dialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Pliki z warto�ciami oddzielonymi przecinkiem (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*|Pliki wymy�lone (*.imaginary)|*.imaginary";
            oPD_dialog.FileName = "plik_domy�lny.txt";
            oPD_dialog.CheckFileExists = true;
            oPD_dialog.CheckPathExists = false;
            DialogResult result = oPD_dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                MessageBox.Show(oPD_dialog.FileName);
            }
            sFD_dialog = new SaveFileDialog();
            sFD_dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            sFD_dialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Pliki z warto�ciami oddzielonymi przecinkiem (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*|Pliki wymy�lone (*.imaginary)|*.imaginary";
            DialogResult result2 = sFD_dialog.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show(sFD_dialog.FileName);
                MessageBox.Show(sFD_dialog.FilterIndex.ToString());
            }
            
        }
    }
}