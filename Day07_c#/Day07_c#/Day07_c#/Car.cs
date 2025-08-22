namespace Day07_c_
{
    class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }

        // 1. Default constructor
        public Car()
        {
            Id = 0;
            Brand = "Unknown";
            Price = 0.0;
        }

        // 2. Constructor with one parameter
        public Car(int id)
        {
            Id = id;
            Brand = "Unknown";
            Price = 0.0;
        }

        // 3. Constructor with two parameters
        public Car(int id, string brand)
        {
            Id = id;
            Brand = brand;
            Price = 0.0;
        }

        // 4. Constructor with all parameters
        public Car(int id, string brand, double price)
        {
            Id = id;
            Brand = brand;
            Price = price;
        }

        public override string ToString()
        {
            return $"Car: Id={Id}, Brand={Brand}, Price={Price}";
        }
    }
}
