namespace CashForMen
{
    internal class Guy
    {
        public string name;
        public int cash;

        public int GiveCash(int amount)
        {
            if (amount <= cash && amount > 0)
            {
                cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("Nie mam wystarczającej ilości pieniędzy, aby Ci dać " + amount, name + " powiedział...");
                return 0;
            }
        }
        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + " to nie jest ilość pieniędzy, jaką mągę wziąć.", name + " powiedział...");
                return 0;
            }
        }
    }
}
