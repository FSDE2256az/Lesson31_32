namespace _2_LocalFunction;

internal class Program
{

    static void BooGlobal()
    {
        Console.WriteLine("BooGlobal Started");
    }



    static void Foo()
    {
        Console.WriteLine("Foo started");

        Boo();

        void Boo()
        {
            Console.WriteLine("Boo Started");
        }
    }


    static void Something(int value)
    {
        Console.WriteLine($"Value: {value}");


        void Helper()
        {
            Console.WriteLine($"Helper: {value}");
        }


        static void HelperStatic()
        {
            int x = 10;
            Console.WriteLine($"HelperStatic started: {x}");
            // Console.WriteLine($"HelperStatic started: {value}"); // Error => static olmadigi ucun
        }

        static void HelperStaticWithValue(int param)
        {
            Console.WriteLine($"HelperStaticWithValue started: {param}");

        }

        Helper();
        HelperStatic();
        HelperStaticWithValue(value);
    }


    static void Main(string[] args)
    {

        // Foo();
        // BooGlobal();
        // Boo();

        Something(42);
    }
}
