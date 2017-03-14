using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    class Program
    {
        {
            private A()
            {
                Console.WriteLine("a");
            }
            class B : A
            {
                public B()
                {
                    Console.WriteLine("B");
                }
            }
            static void Main(string[] args)
            {
                A a = new B();
            }
        }
    }
}
