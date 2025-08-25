namespace Day08_c_
{
    public class Square : Shape
    {
        private double width;
        private double height;

        public Square(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Override Draw()
        public override void Draw()
        {
            Console.WriteLine("Drawing Square");
        }

        // Implement CalculateArea()
        public override double CalculateArea()
        {
            return width * height;
        }
    }
}
