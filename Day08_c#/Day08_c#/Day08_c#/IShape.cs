namespace Day08_c_
{
    public interface IShape
    {
        double Area { get; }   // Read-only property
        void Draw();           // Method to be implemented
        void PrintDetails()
        {
            Console.WriteLine($"Shape Details: Area = {Area}");
        }
    }

}
