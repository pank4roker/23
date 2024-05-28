using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        enum Menu { Enter = 1, Conclusion, ConclusionByGender, Exit }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                Console.WriteLine("\nВыберите пункт:");
                Console.WriteLine("1. Ввод студентов");
                Console.WriteLine("2. Вывод всех студентов");
                Console.WriteLine("3. Вывод студентов по полу");
                Console.WriteLine("4. Выход");

                int choice = Convert.ToInt32(Console.ReadLine());
                Menu menuChoice = (Menu)choice;

                switch (menuChoice)
                {
                    case Menu.Enter:
                        Console.Write("Введите количество студентов (N): ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            students.Add(Student.InPut());
                        }
                        break;

                    case Menu.Conclusion:
                        Console.WriteLine("Список всех студентов:");
                        Student.OutPuts(students);
                        break;

                    case Menu.ConclusionByGender:
                        Console.WriteLine("Список студентов по полу:");
                        Student.OutPutGender(students);
                        break;

                    case Menu.Exit:
                        Console.WriteLine("Выход из программы.");
                        return;

                    default:
                        Console.WriteLine("Некорректный выбор. Пожалуйста, выберите снова.");
                        break;
                }
            }
        }
    }
}
