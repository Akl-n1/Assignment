namespace Day06_c_
{
    internal struct Point2
    {
        public int X;
        public int Y;

        public Point2(int x)
        {
            X = x;
            Y = 0;
        }

        public Point2(int x, int y)
        {
            X = x;
            Y = y;
        }

        #region Problem 4
        //public void Display()
        //{
        //    Console.WriteLine($"X = {X}, Y = {Y}");
        //} 
        #endregion

        #region Problem 5 
        //public override string ToString()
        //{
        //    return $"Point Coordinates -> X: {X}, Y: {Y}";
        //} 
        #endregion



    }
}
