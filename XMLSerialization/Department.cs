﻿using System.Xml.Serialization;

namespace XMLSerialization
{
    public class Department
    {
        [XmlElement(ElementName = "Name")]
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
