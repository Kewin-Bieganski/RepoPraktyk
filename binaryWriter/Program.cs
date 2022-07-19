namespace binaryWriter
{
    internal class Program
    {
        string fullPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\bin.dat";

        int intValue = 48769414;
        string stringValue = "Witaj!";
        byte[] byteArray = { 47, 129, 0, 116 };
        float floatValue = 491.695F;
        char charValue = 'E';

        public static void Main()
        {
            new Program();
        }

        Program()
        {
            using (FileStream output = File.Create(fullPath))
            using (BinaryWriter binaryWriter = new BinaryWriter(output))
            {
                binaryWriter.Write(intValue);
                binaryWriter.Write(stringValue);
                binaryWriter.Write(byteArray);
                binaryWriter.Write(floatValue);
                binaryWriter.Write(charValue);
            }
            byte[] dataWritten = File.ReadAllBytes(fullPath);
            foreach (byte b in dataWritten)
                Console.Write("{0:x2} ", b);
            Console.WriteLine(" - {0} bajtów", dataWritten.Length);
            Console.ReadKey();
            using (FileStream input = File.OpenRead(fullPath))
            using (BinaryReader binaryReader = new BinaryReader(input))
            {
                int intRead = binaryReader.ReadInt32();
                string stringRead = binaryReader.ReadString();
                byte[] byteArrayRead = binaryReader.ReadBytes(4);
                float floatRead = binaryReader.ReadSingle();
                char charRead = binaryReader.ReadChar();
                Console.Write("int: {0} string: {1} bajty: ", intRead, stringRead);
                foreach (byte b in byteArrayRead)
                    Console.Write("{0} ", b);
                Console.Write("float: {0} char: {1} ", floatRead, charRead);
                Console.ReadKey();
            }
        }
    }
}