using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    [Serializable]
    public class Product : ISerializable
    {
        public string Name;
        public decimal Price;

        public Product()
        {
        }

        protected Product(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("n");
            Price = info.GetDecimal("p");
        }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("n", Name);
            info.AddValue("p", Price);
        }
    }
}
