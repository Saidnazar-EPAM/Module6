using Task3;

var department = new Department();

department.DepartmentName = "Olma";
department.Employees = new List<Employee>()
{
    new Employee() { EmployeeName = "Zokir" },
    new Employee() { EmployeeName = "O'ktam" }
};

var departmentCopy = department.Clone();

department.Employees[0].EmployeeName = "Bahrom";
if(department.Employees[0].EmployeeName != departmentCopy.Employees[0].EmployeeName)
{
    Console.WriteLine("Success");
}else
{
    Console.WriteLine("Fail");
}