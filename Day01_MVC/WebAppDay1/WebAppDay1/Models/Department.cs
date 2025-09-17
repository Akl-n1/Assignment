namespace WebAppDay1.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ManagerNmae { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
