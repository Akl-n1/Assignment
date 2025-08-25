namespace Day08_c_
{
    internal class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Implement Area property
        public double Area
        {
            get { return Math.PI * radius * radius; }
        }

        // Implement Draw method
        public void Draw()
        {
            Console.WriteLine($"Drawing a Circle with Radius = {radius}, Area = {Area:F2}");
        }

    }
}
