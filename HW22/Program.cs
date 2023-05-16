using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "-1,57,3pvv45";

            double result = Converter.StringToDouble(input);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
