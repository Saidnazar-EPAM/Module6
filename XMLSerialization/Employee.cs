
using System.Xml.Serialization;

namespace XMLSerialization
{
    public class Employee
    {
        [XmlElement(ElementName = "Name")]
        public string EmployeeName { get; set; }
    }
}
