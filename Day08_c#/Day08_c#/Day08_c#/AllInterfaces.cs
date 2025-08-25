namespace Day08_c_
{
    public interface IVehicle
    {
        void StartEngine();
        void StopEngine();
    }
    public interface IWalkable
    {
        void Walk();
    }
    public interface ILogger
    {
        void Log(string message)
        {
            Console.WriteLine($"[Default Logger]: {message}");
        }
    }

    public interface IShapeSeries
    {
        double CurrentShapeArea { get; set; }
        void GetNextArea();
        void ResetSeries();
    }

}
