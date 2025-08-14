namespace Day06_c_
{
    struct Employee
    {
        private int empId;
        private string name;
        private double salary;

        // Constructor to initialize the Employee struct
        public Employee(int id, string name, double salary)
        {
            this.empId = id;
            this.name = name;
            this.salary = salary;
        }
        // Method to display employee details
        public string GetName()
        {
            return name;
        }
        public void SetName(string Name)
        {
            name = Name;
        }
        public int EmpId
        {
            get { return empId; }
            set { empId = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public void ShowDetails()
        {
            Console.WriteLine($"ID: {empId}, Name: {name}, Salary: {salary}");
        }
    }
}
