namespace Day08_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1
            //IShape rect = new Rectangle(10, 5);

            //rect.Draw();

            //Console.WriteLine("Rectangle Area: " + rect.Area); 
            #endregion

            #region Problem 2

            //IShape circle = new Circle(7);
            //// Call Draw()
            //circle.Draw();

            //// Call the default PrintDetails() from interface
            //circle.PrintDetails(); 
            #endregion

            #region Problem 3

            //Car myCar = new Car("Toyota");

            //IMovable movableCar = myCar;

            //movableCar.Move(); 
            #endregion

            #region Problem 4
            //File myFile = new File("data.txt");

            //myFile.Read();
            //myFile.Write();

            //IReadable readableFile = myFile;
            //readableFile.Read();

            //IWritable writableFile = myFile;
            //writableFile.Write(); 
            #endregion

            #region Problem 5
            //Shape rect = new Square(10, 5);

            //rect.Draw();

            //Console.WriteLine("Square Area: " + rect.CalculateArea());
            #endregion

            #region Problem 6 
            //IVehicle myBike = new Bike("Honda");
            //IVehicle myMoto = new Motosicle("Race");


            //myBike.StartEngine();
            //myBike.StopEngine();

            //myMoto.StartEngine();
            //myMoto.StopEngine(); 
            #endregion

            #region Problem 7
            //Product[] products = new Product[]
            //{
            //     new Product("Laptop", 1200),
            //     new Product("Smartphone", 800),
            //     new Product("Tablet", 400)
            //};
            //Array.Sort(products);
            //foreach (var p in products)
            //    Console.WriteLine(p);

            #endregion

            #region Problem 8
            //Console.WriteLine("=== Original Student ===");
            //Student s1 = new Student(1, "Ali", "Math", 90);
            //s1.Display();

            //Console.WriteLine("\n=== Shallow Copy ===");
            //Student shallow = s1.ShallowCopy();
            //shallow.Grades.Score = 50;
            //shallow.Display();//50
            //s1.Display(); //50
            //Console.WriteLine("\n=== Deep Copy ===");
            //Student deep = new Student(s1);
            //deep.Grades.Score = 80;
            //deep.Display();//80
            //s1.Display(); //50 
            #endregion

            #region Problem 9
            //Robot r = new Robot();

            //r.Walk();

            //IWalkable walkable = r;
            //walkable.Walk(); 
            #endregion

            #region Problem 10
            //Account acc1 = new Account(101, "Mahmoud", 5000);
            //acc1.DisplayAccount();

            //// Attempt to set invalid values
            //acc1.AccountId = -5;
            //acc1.Balance = -100;
            //acc1.AccountHolder = "";

            //// Correctly update values
            //acc1.AccountId = 102;
            //acc1.Balance = 7500;
            //acc1.AccountHolder = "Mahmoud Akl";
            //acc1.DisplayAccount(); 
            #endregion

            #region Problem 11
            //ILogger logger = new ConsoleLogger();
            //logger.Log("This is a test log message.");
            #endregion

            #region Problem 12 
            //IShapeSeries CircleSeries = new CircleSeries();
            //IShapeSeries SquareSeries = new SquareSeries();
            //PrintTenShapes.PrintTenShape(CircleSeries);
            //Console.WriteLine("=======================");
            //PrintTenShapes.PrintTenShape(SquareSeries); 
            #endregion

            #region Problem 13
            //    Console.WriteLine("\n=== Shapes Sorting ===");
            //    Shapes[] shapes =
            //    {
            //    new Shapes("Square", 25),
            //    new Shapes("Circle", 78.5),
            //    new Shapes("Rectangle", 40),
            //    new Shapes("Triangle", 30),
            //    new Shapes("Square", 16)
            //};
            //    Array.Sort(shapes);
            //    foreach (var shape in shapes)
            //        Console.WriteLine(shape);
            #endregion

            #region Problem 14
            //Triangle triangle = new Triangle { Dimension1 = 3, Dimension2 = 4 };
            //Console.WriteLine("Triangle:");
            //Console.WriteLine($"Area = {triangle.CalculateArea()}");
            //Console.WriteLine($"Perimeter = {triangle.Perimeter}");

            //Console.WriteLine();

            //Rectangles rectangle = new Rectangles { Dimension1 = 5, Dimension2 = 7 };
            //Console.WriteLine("⬛ Rectangle:");
            //Console.WriteLine($"Area = {rectangle.CalculateArea()}");
            //Console.WriteLine($"Perimeter = {rectangle.Perimeter}"); 
            #endregion

            #region Problem 15
            //Model[] shapes = new Model[3];
            //shapes[0] = new Model { Dimension1 = 4, Dimension2 = 5 }; // Area = 20
            //shapes[1] = new Model { Dimension1 = 3, Dimension2 = 6 }; // Area = 18
            //shapes[2] = new Model { Dimension1 = 2, Dimension2 = 7 }; // Area = 14

            //double[] areas = new double[shapes.Length];
            //for (int i = 0; i < shapes.Length; i++)
            //{
            //    areas[i] = shapes[i].Area();
            //}

            //Sort.SelectionSort(areas);

            //Console.WriteLine("Sorted Areas:");
            //foreach (var a in areas)
            //{
            //    Console.WriteLine(a);
            //} 
            #endregion
        }
    }
}
