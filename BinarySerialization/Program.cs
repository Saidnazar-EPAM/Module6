using BinarySerialization;
using System.Runtime.Serialization.Formatters.Binary;

var department = new Department();

department.DepartmentName = "Olma";
department.Employees = new List<Employee>()
{
    new Employee() { EmployeeName = "Zokir" },
    new Employee() { EmployeeName = "O'ktam" }
};

var formatter = new BinaryFormatter();
using (var stream = new FileStream("Olma.bin", FileMode.Create, FileAccess.Write))
{
    formatter.Serialize(stream, department);
}

using (var stream = new FileStream("Olma.bin", FileMode.Open, FileAccess.Read))
{
    department = (Department) formatter.Deserialize(stream);
    Console.WriteLine(department.DepartmentName);
    foreach (var item in department.Employees)
    {
        Console.WriteLine(item.EmployeeName);
    }
}