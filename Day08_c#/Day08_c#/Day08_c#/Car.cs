namespace Day08_c_
{
    public class Car : IMovable
    {
        private string model;

        public Car(string model)
        {
            this.model = model;
        }

        public void Move()
        {
            Console.WriteLine($"The car {model} is moving...");
        }
    }
    public interface IReadable
    {
        void Read();
    }

    public interface IWritable
    {
        void Write();
    }
}
