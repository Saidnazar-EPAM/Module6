using XMLSerialization;
using System.Xml.Serialization;

var department = new Department();

department.DepartmentName = "Olma";
department.Employees = new List<Employee>()
{
    new Employee() { EmployeeName = "Zokir" },
    new Employee() { EmployeeName = "O'ktam" }
};

var serializer = new XmlSerializer(typeof(Department));
using (var stream = new FileStream("Olma.xml", FileMode.Create, FileAccess.Write))
{
    serializer.Serialize(stream, department);
}

using (var stream = new FileStream("Olma.xml", FileMode.Open, FileAccess.Read))
{
    department = (Department)serializer.Deserialize(stream);
    Console.WriteLine(department.DepartmentName);
    foreach (var item in department.Employees)
    {
        Console.WriteLine(item.EmployeeName);
    }
}