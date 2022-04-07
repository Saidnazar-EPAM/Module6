using JsonSerialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

var department = new Department();

department.DepartmentName = "Olma";
department.Employees = new List<Employee>()
{
    new Employee() { EmployeeName = "Zokir" },
    new Employee() { EmployeeName = "O'ktam" }
};

using (var stream = new FileStream("Olma.json", FileMode.Create, FileAccess.Write))
{
    var json = JsonSerializer.Serialize(department);
    var byteArray = Encoding.UTF8.GetBytes(json);
    await stream.WriteAsync(byteArray);
}

using (var stream = new FileStream("Olma.json", FileMode.Open, FileAccess.Read))
{
    department = await JsonSerializer.DeserializeAsync<Department>(stream); 
    Console.WriteLine(department.DepartmentName);
    foreach (var item in department.Employees)
    {
        Console.WriteLine(item.EmployeeName);
    }
}