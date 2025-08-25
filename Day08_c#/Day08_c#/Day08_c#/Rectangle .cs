namespace Day08_c_
{
    public class Rectangle : IShape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Area
        {
            get { return width * height; }
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a Rectangle with Width = {width}, Height = {height}, Area = {Area}");
        }
    }
}
