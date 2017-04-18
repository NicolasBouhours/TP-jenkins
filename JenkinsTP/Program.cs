using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: CLSCompliant(true)]
namespace JenkinsTP
{
    public static class Program
    {
        static void Main()
        {
            Console.WriteLine(Add(8, 6));
            Console.WriteLine(Add(8, 6));
            Console.WriteLine(Add(8, 6));
            Console.WriteLine(Add(8, 6));
            Console.WriteLine("azertyuiopqsdfghhjhkklwxxcvbzeertyusdfghdfrfguinjhigiefgfgfnjinjfgnjdfjbkjnfgjbjbfgjbgfbjkdfjkgfhguieruierueriuiuirtuirtbhvebuhvfbhuvfbh");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Div(int a, int b)
        {
            return a/b;
        }

        public static int Adding(int a, int b)
        {
            Console.WriteLine(Add(8, 6));
            Console.WriteLine(Add(8, 6));
            Console.WriteLine(Add(8, 6));
            Console.WriteLine(Add(8, 6));
            Console.WriteLine("azertyuiopqsdfghhjhkklwxxcvbzeertyusdfghdfrfguinjhigiefgfgfnjinjfgnjdfjbkjnfgjbjbfgjbgfbjkdfjkgfhguieruierueriuiuirtuirtbhvebuhvfbhuvfbh");

            return a + b;
        }
    }
}
