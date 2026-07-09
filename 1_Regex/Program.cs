using System.Text.RegularExpressions;

namespace _1_Regex;

// string email = "";

/*
 

*/


public class Program
{
    static void Main(string[] args)
    {
        // string pattern = "^Kamran";
        // string pattern = "^[a-zA-Z]+$";
        // string pattern = "[A-Z]";
        // string pattern = "[a-z]";
        // string pattern = "^[0-9]+$";
        // string pattern = "^[a-zA-Z0-9]+$";
        // string pattern = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$";
        // 
        // string fullname = "15649Kamran@dd.az";
        // 
        // var regex = new Regex(pattern);
        // 
        // Console.WriteLine(regex.IsMatch(fullname));


        string pattern = "(Mr\\.? |Mrs\\.? |Miss |Ms\\.? )";
        string[] names = { "Mr. Henry Hunt", "Ms. Sara Samuels",
                          "Abraham Adams", "Ms. Nicole Norris" };

        foreach (string name in names)
            Console.WriteLine(Regex.Replace(name, pattern, String.Empty));


    }
}
