using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsTP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(8, 6));
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Div(int a, int b)
        {
            return a/b;
        }
    }
}
