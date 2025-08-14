namespace Day06_c_
{
    internal class Program
    {
        #region problem 6
        //static void ModifyPoint(Problem_6.Point p)
        //{
        //    p.X = 100;
        //    p.Y = 200;
        //    Console.WriteLine($"Inside ModifyPoint: X={p.X}, Y={p.Y}");
        //}
        //static void ModifyEmployee(Problem_6.Employee emp)
        //{
        //    emp.Name = "Updated Name";
        //    emp.Age = 99;
        //    Console.WriteLine($"Inside ModifyEmployee: Name={emp.Name}, Age={emp.Age}");
        //} 
        #endregion
        static void Main(string[] args)
        {
            #region Problem 1
            //Point p1 = new Point(); // X=0, Y=0
            //Console.WriteLine(p1);

            //// باستخدام الـ parameterized constructor
            //Point p2 = new Point(3, 4);
            //Console.WriteLine(p2); 
            #endregion

            #region Problem 2
            //TypeA obj = new TypeA();
            //obj.G = 5; // يمكن الوصول إلى G لأنه internal
            //obj.H = 9; // يمكن الوصول إلى H لأنه public
            ////obj.F = 15; // غير مسموح به لأن F هو private

            //obj.ShowValues(); // يطبع F, G, H 
            #endregion

            #region Problem 3 
            //Employee emp = new Employee(101, "Ahmed", 5000);
            //emp.ShowDetails();
            //emp.SetName("Ali");
            //emp.Salary = 6000;
            //emp.EmpId = 102;
            //emp.ShowDetails(); 
            #endregion

            #region Problem 4 
            //Point2 p1 = new Point2(5);
            //p1.Display(); // X = 5, Y = 0

            //Point2 p2 = new Point2(10, 20);
            //p2.Display(); // X = 10, Y = 20 
            #endregion

            #region Problem 5

            //Point2 p1 = new Point2(5);
            //Point2 p2 = new Point2(10, 20);
            //Point2 p3 = new Point2(-3, 7);

            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            //Console.WriteLine(p3); 
            #endregion

            #region problem 6 
            //Problem_6.Point p1 = new Problem_6.Point(10, 20);
            //Console.WriteLine($"Before ModifyPoint: X={p1.X}, Y={p1.Y}");
            //ModifyPoint(p1);
            //Console.WriteLine($"After ModifyPoint: X={p1.X}, Y={p1.Y}"); // مش هيتغير

            //Console.WriteLine();

            //Problem_6.Employee e1 = new Problem_6.Employee("Ali", 25);
            //Console.WriteLine($"Before ModifyEmployee: Name={e1.Name}, Age={e1.Age}");
            //ModifyEmployee(e1);
            //Console.WriteLine($"After ModifyEmployee: Name={e1.Name}, Age={e1.Age}"); // هيتغير

            #endregion

        }
    }
}
