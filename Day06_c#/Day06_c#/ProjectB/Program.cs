using Day06_c_;
namespace ProjectB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TypeA obj = new TypeA();
            //obj.G = 5; // يمكن الوصول إلى G لأنه internal
            //obj.F = 15; // غير مسموح به لأن F هو private

            obj.H = 10; // يمكن الوصول إلى H لأنه public
            obj.ShowValues(); // يطبع F, G, H

        }
    }
}
