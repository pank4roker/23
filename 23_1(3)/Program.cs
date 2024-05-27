using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_1_3_
{
  
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую переменную: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вторую переменную: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Func func = new Func();
            func.Operations(a, b);
            Console.ReadLine();
        }
        
    } 
}


