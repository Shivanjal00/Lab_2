using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instant_1
{
    class employee
        {
            string n;
            int a;
            double s;
            public employee(string name, int age, double sal)
            {
                n = name;
                a = age;
                s = sal;
            }


            public void display()
            {
                Console.WriteLine(n);
                Console.WriteLine(a);
                Console.WriteLine(s);
            }

        }


        internal class Program
        {
            static void Main(string[] args)
            {
                employee e = new employee("shiva", 22, 1000000);
                e.display();
            }
        }
}
