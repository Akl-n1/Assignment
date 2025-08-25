namespace Day08_c_
{
    internal class Product : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public int CompareTo(object? obj)
        {
            if (obj is Product other)
            {
                return other.Price.CompareTo(this.Price);
            }
            throw new ArgumentException("Object is not a Product");
        }
        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}";
        }
    }
    class GradeInfo
    {
        public string Subject;
        public double Score;

        public GradeInfo(string subject, double score)
        {
            Subject = subject;
            Score = score;
        }
    }
    class Student
    {
        public int Id;
        public string Name;
        public GradeInfo Grades;
        public Student(int id, string name, string subject, double score)
        {
            Id = id;
            Name = name;
            Grades = new GradeInfo(subject, score);
        }
        // Copy Constructor for deep copy
        public Student(Student student)
        {
            Id = student.Id;
            Name = student.Name;
            Grades = new GradeInfo(student.Grades.Subject, student.Grades.Score);

        }
        // Shallow Copy Method
        public Student ShallowCopy()
        {
            return (Student)this.MemberwiseClone();
        }
        public void Display()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Subject: {Grades.Subject}, Score: {Grades.Score}");
        }

    }
}
