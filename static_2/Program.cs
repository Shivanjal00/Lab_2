using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_2
{

    static class Logger
    {
        public static void Logmsg(string s)
        {
            
            Console.WriteLine(s);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a msg");
            string ss = Console.ReadLine();
            Logger.Logmsg(ss);
        }
    }
}
