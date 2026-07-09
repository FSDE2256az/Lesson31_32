using System.Reflection;

namespace _5_Reflaction;


class Person
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Person()
    {
        Console.WriteLine("Person default constructor");
    }
}

struct Location
{
    public string Latitude { get; set; }
    public string Longitude { get; set; }

    public Location()
    {
        Console.WriteLine("Location default constructor");
    }
}




public class Program
{
    static void Main(string[] args)
    {
        var assembly = Assembly.GetExecutingAssembly();


        var types = assembly.GetTypes();

        foreach (var type in types)
        {
            Console.WriteLine(type.Name);


            foreach (var property in type.GetProperties())
            {
                Console.WriteLine(property.Name);
                Console.WriteLine(property.GetMethod);
                Console.WriteLine(property.SetMethod);
                Console.WriteLine(property.PropertyType);

            }
        }

    }
}
