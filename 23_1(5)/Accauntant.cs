using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_1_5_
{
    enum Employees { Менеджер = 160, Программист = 150, Тестировщик = 120 }
    class Accauntant
    {
        public void InPut()
        {
            while (true)
            {
                Console.Write("Введите должность сотрудника (Менеджер, Программист, Тестировщик): ");
                string position = Console.ReadLine();
                if (Enum.TryParse(position, out Employees employee))
                {
                    Console.Write("Введите количество отработанных часов: ");
                    int hours = Convert.ToInt32(Console.ReadLine());
                    if (hours > 0)
                    {
                        bool bonus = AskForBonus(employee, hours);
                        string bonusMessage = bonus ? "положена премия." : "не положена премия.";
                        Console.WriteLine($"Сотруднику {bonusMessage}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: введено некорректное значение часов.");
                    }

                }
                else
                {
                    Console.WriteLine("Ошибка: введено некорректное значение.");
                }
            }
        }
        bool AskForBonus(Employees worker, int hours)
        {
            return hours > (int)worker;
        }
    }
}
