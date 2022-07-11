namespace baseClass
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new MySubClass("Blah blah", 123);
        }
    }
}