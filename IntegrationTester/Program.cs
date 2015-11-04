using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTester
{
    public class Foo
    {
        public static string Do()
        {
            return "Bar";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Foo.Do());
            Console.ReadKey();
        }
    }
}
