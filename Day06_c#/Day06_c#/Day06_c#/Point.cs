namespace Day06_c_
{
    internal struct Point
    {
        public double X;
        public double Y;

        public Point()
        {
            X = 1;
            Y = 1;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Override ToString
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
