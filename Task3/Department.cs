using System.Runtime.Serialization.Formatters.Binary;

namespace Task3
{
    [Serializable]
    public class Department
    {
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; }

        public Department Clone()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                if (this.GetType().IsSerializable)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, this);
                    stream.Position = 0;
                    var clonedDepartment = formatter.Deserialize(stream);
                    return (Department)clonedDepartment;
                }
                return null;
            }
        }
    }
}
