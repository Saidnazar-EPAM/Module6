using System.Text.Json.Serialization;

namespace JsonSerialization
{
    public class Department
    {
        [JsonPropertyName("Name")]
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
