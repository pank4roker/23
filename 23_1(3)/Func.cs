using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_1_3_
{
    enum Operation { Sum = 1, Sub, Mul, Div, Exit }
    class Func
    {
        public void Operations(int a,int b)
        {
            while (true)
            {
                Console.WriteLine("Какое действие вы хотите сделать с переменными:\n1 - Сложение\n2 - Вычитание\n3 - Умножение\n4 - Деление\n5 - Выход");
                int oper = Convert.ToInt32(Console.ReadLine());
                switch ((Operation)oper)
                {
                    case Operation.Sum:
                        
                        Console.WriteLine($"\nСложение = {(a + b)}\n");
                        break;
                    case Operation.Sub:
                        Console.WriteLine($"\nВычитание = {(a - b)}\n");
                        break;
                    case Operation.Mul:
                        Console.WriteLine($"\nУмножение = {(a * b)}\n");
                        break;
                    case Operation.Div:
                        Console.WriteLine($"\nДеление = {(a / b)}\n");
                        break;
                    case Operation.Exit:
                        return;
                }
            }
        }
    }
}
