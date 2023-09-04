using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instant_2
{
    public class bank
    {
        int ac;
        string n;
        double b;

        public bank(int acc, string name, double bal)
        {
            ac = acc;
            n = name;
            b = bal;
        }


        public void deposit(int d)
        {
            b = b + d;
            Console.WriteLine("balance after deposit  " + b);
        }

        public void wdr(int w)
        {
            b = b - w;
            Console.WriteLine("balance after  withdrawal  " + b);
        }

        public void display()
        {
            Console.WriteLine("name of account holder is  " + n);
            Console.WriteLine("account number is  " + ac);
            Console.WriteLine("balance is  " + b);

        }



    }


    internal class Program
    {
        static void Main(string[] args)
        {
            bank bnk = new bank(1111, "Shiva", 89000000);
            bnk.deposit(1000);
            bnk.wdr(500);
            bnk.display();
        }
    }
}
