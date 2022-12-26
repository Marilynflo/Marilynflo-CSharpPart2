using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            const string helloWorld = "Welcome"; // creating const variable
            Console.WriteLine(helloWorld);

            var user1 = new Class1("To Online Learning", 101); //Create an object of the class Class1
            Console.WriteLine(user1.Name); //Print the value
            Console.WriteLine(user1.Acctcode); //Print the value
            Console.Read();
        }
    }
}
