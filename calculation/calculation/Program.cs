using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculation
{
    class Program
    {
        public void calculation()
        {
            Console.WriteLine("enter a principle of amount");
            double principle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter a time");
            double time = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter a rate of interest");
            double rate = Convert.ToDouble(Console.ReadLine());
            double simpleinterest = principle * time * rate / 100;
            Console.WriteLine(simpleinterest);
        }
        static void Main(string[] args)
        {
            Program objectname = new Program();
            objectname.calculation();
            Console.Read();  
            }
        }
    }

