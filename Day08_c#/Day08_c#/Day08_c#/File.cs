namespace Day08_c_
{
    public class File : IReadable, IWritable
    {
        private string fileName;

        public File(string fileName)
        {
            this.fileName = fileName;
        }

        public void Read()
        {
            Console.WriteLine($"Reading data from {fileName}...");
        }

        public void Write()
        {
            Console.WriteLine($"Writing data to {fileName}...");
        }
    }

}
