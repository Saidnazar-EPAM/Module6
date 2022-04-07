using Task2;
using System.Runtime.Serialization.Formatters.Binary;

var product = new Product();

product.Name = "Olma";
product.Price = 3000;

var formatter = new BinaryFormatter();
using (var stream = new FileStream("Olma.bin", FileMode.Create, FileAccess.Write))
{
    formatter.Serialize(stream, product);
}

using (var stream = new FileStream("Olma.bin", FileMode.Open, FileAccess.Read))
{
    product = (Product)formatter.Deserialize(stream);
    Console.WriteLine(product.Name + " - " + product.Price);
    
}