using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace partial2
{
    public partial class employee(String n, int id, int y)
    {
        public string Name = n;
        public int Id = id;
        public long year = y;

        public void print()
        {
            Console.WriteLine("Name of employee is "+Name);
            Console.WriteLine("ID of employee is "+Id);
            Console.WriteLine("Year of Working"+year);
        }
        
        public void sal()
        {
            Console.WriteLine("Salary of this employee is " + year * 15000);
        }
    }
}
