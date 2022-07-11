using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseClass
{
    internal class MyBaseClass
    {
        public MyBaseClass(string baseClassNeedsThis)
        {
            MessageBox.Show("To jest klasa bazowa: " + baseClassNeedsThis);
        }
    }
}
