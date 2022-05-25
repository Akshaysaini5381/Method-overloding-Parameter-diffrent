using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overloding_Parameter_diffrent
{
    class name
    {
      internal int show(int num)
        {
            return num;
        }
        internal int show(int num, int num1)
        {
            return num + num1;
        }
        internal int show(int num, int num1, int num2)
        {
            return num + num1 + num2;
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {

            name n = new name();
            int n1 = n.show(10,20,10);
            Console.WriteLine(n1);
            Console.ReadLine();
        }
    }
}
