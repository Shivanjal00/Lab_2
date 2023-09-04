using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employee e = new employee("Shivanjal",001,5);
            Console.WriteLine("Details of emplyee");
            e.print();
            e.sal();
        }
    }
}
