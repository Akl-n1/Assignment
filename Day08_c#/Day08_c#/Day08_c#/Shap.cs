namespace Day08_c_
{
    public abstract class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shape");
        }

        public abstract double CalculateArea();
    }
}
