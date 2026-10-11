using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program80
{
    internal class Program
    {
        static void Main()
        {
            bool result = (false && (10 + 0 == 1)) || (true && (20 > 15));
            Console.WriteLine(result); // True
        }
    }
}

