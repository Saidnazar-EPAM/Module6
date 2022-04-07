using System.Text.Json.Serialization;

namespace JsonSerialization
{
    public class Employee
    {
        [JsonPropertyName("Name")]
        public string EmployeeName { get; set; }
    }
}
