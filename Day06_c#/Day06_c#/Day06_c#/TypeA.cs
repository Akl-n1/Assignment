namespace Day06_c_
{
    public class TypeA
    {
        private int F;      // خاص بالكلاس نفسه
        internal int G;     // متاح في نفس الـ Assembly
        public int H;       // متاح من أي مكان

        public TypeA()
        {
            F = 1;
            G = 2;
            H = 3;
        }

        public void ShowValues()
        {
            Console.WriteLine($"F = {F}, G = {G}, H = {H}");
        }
    }
}
