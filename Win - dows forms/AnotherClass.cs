using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win___dows_forms
{
    internal class AnotherClass
    {
        public static void Main()
        {
            MessageBox.Show("Inne wejście");
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
