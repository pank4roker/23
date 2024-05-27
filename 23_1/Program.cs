using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_1
{
    class Program
    {
        enum DaysandMonth {январь,февраль,март,апрель,май,июнь,июль,август,сентябрь,октябрь,ноябрь,декабрь}
        enum Week { Sat, Sun, Mon, Tue, Wed, Thu, Fri }
        static void Main(string[] args)
        {
           //Task1
           DaysandMonth i;
           for (i = DaysandMonth.январь;i<=DaysandMonth.декабрь;i++)
           {
                Console.WriteLine($"{(int)i}\t{i}");
           }
            //Task2
            Console.WriteLine();
           Week w;
           for(w = Week.Sat;w<=Week.Fri;w++)
           {
                Console.WriteLine($"{w} имеет значение {(int)w}");
           }
           Console.ReadKey();
        }
    }
}
