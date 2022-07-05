namespace valueCasting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_cast_Click(object sender, EventArgs e)
        {
            decimal myDecimalValue = 10;
            int myIntValue = (int)myDecimalValue;
            MessageBox.Show("myIntValue jest równe " + myIntValue);

            int myInt = 10;
            byte myByte = (byte)myInt;
            double myDouble = (double)myByte;
            //bool myBool = (bool)myDouble;
            string myString = "false";
            //myBool = (bool)myString;
            //myString = (string)myInt;
            myString = myInt.ToString();
            //myBool = (bool)myByte;
            //myByte = (byte)myBool;
            short myShort = (short)myInt;
            char myChar = 'x';
            //myString = (string)myChar;
            long myLong = (long)myInt;
            decimal myDecimal = (decimal)myLong;
            myString = myString + myInt + myByte
            + myDouble + myChar;

            long l = 139401930;
            short s = 516;
            double d = l - s;
            d = d / 123.456;
            MessageBox.Show(this.ToString() + " OdpowiedŸ brzmi: " + d.ToString() + " " + MyMethod(true) + " " + MyMethod(1));

        }

        public void @void()
        {
            int @public = 0;
        }

        public int MyMethod(object yesNo)
        {
            if (yesNo.Equals(true))
            {
                return 45;
            }
            else
            {
                return 61;
            }
        }
    }
}