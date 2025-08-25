namespace Day08_c_
{
    public class Bike : IVehicle
    {
        private string model;

        public Bike(string model)
        {
            this.model = model;
        }

        public void StartEngine()
        {
            Console.WriteLine($"Bike {model}: Engine started 🚗");
        }

        public void StopEngine()
        {
            Console.WriteLine($"Bike {model}: Engine stopped ❌");
        }
    }
    public class Motosicle : IVehicle
    {
        private string brand;

        public Motosicle(string brand)
        {
            this.brand = brand;
        }

        public void StartEngine()
        {
            Console.WriteLine($"Motosicle {brand}: Engine started ");
        }

        public void StopEngine()
        {
            Console.WriteLine($"Motosicle {brand}: Engine stopped");
        }
    }
    class Robot : IWalkable
    {
        // ميثود عادية في الكلاس Robot
        public void Walk()
        {
            Console.WriteLine("Robot is walking using its default method.");
        }

        // Explicit interface implementation
        void IWalkable.Walk()
        {
            Console.WriteLine("Robot is walking (via IWalkable interface).");
        }
    }
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[Console Logger]: {message}");
        }
    }
    class SquareSeries : IShapeSeries
    {
        private int side = 1;
        public double CurrentShapeArea { get; set; }

        public void GetNextArea()
        {
            CurrentShapeArea = side * side;
            side++;
        }

        public void ResetSeries()
        {
            side = 1;
            CurrentShapeArea = 0;
        }
    };
    public class CircleSeries : IShapeSeries
    {
        private double radius = 1;
        public double CurrentShapeArea { get; set; }

        public void GetNextArea()
        {
            CurrentShapeArea = Math.PI * radius * radius;
            radius++;
        }

        public void ResetSeries()
        {
            radius = 1;
            CurrentShapeArea = 0;
        }
    };
    static class PrintTenShapes
    {
        public static void PrintTenShape(IShapeSeries series)
        {
            series.ResetSeries();
            for (int i = 0; i < 10; i++)
            {
                series.GetNextArea();
                Console.WriteLine($"Shape Area: {series.CurrentShapeArea}");
            }
        }
    }
    class Shapes : IComparable<Shapes>
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public Shapes(string name, double area)
        {
            Name = name;
            Area = area;
        }



        public int CompareTo(Shapes? other)
        {
            if (other is null) return 1;
            return this.Area.CompareTo(other.Area);
        }
        public override string ToString()
        {
            return $"{Name} - Area: {Area}";
        }
    }
    abstract class GeometricShape
    {
        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }

        public abstract double CalculateArea();

        public abstract double Perimeter { get; }
    }
    class Triangle : GeometricShape
    {
        public override double CalculateArea()
        {
            return 0.5 * Dimension1 * Dimension2;
        }

        public override double Perimeter
        {
            get { return Dimension1 + Dimension2 + Math.Sqrt(Math.Pow(Dimension1, 2) + Math.Pow(Dimension2, 2)); }
        }
    }
    class Rectangles : GeometricShape
    {
        public override double CalculateArea()
        {
            return Dimension1 * Dimension2;
        }

        public override double Perimeter
        {
            get { return 2 * (Dimension1 + Dimension2); }
        }
    }
    class Model
    {
        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }

        public virtual double Area()
        {
            return Dimension1 * Dimension2; // كمثال: مستطيل
        }
    }

    class Sort
    {
        public static double[] SelectionSort(double[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // Swap the found minimum element with the first element
                double temp = numbers[i];
                numbers[i] = numbers[minIndex];
                numbers[minIndex] = temp;
            }
            return numbers;
        }
    }
}

