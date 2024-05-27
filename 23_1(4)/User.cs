using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_1_4_
{
    enum UserRole {Администратор, Модератор, Пользователь, Гость}
    class User
    {
        public void Role()
        {
            while (true)
            {
                Console.Write("Кем вы являетесь?(Администратор, Модератор, Пользователь, Гость): ");
                string role = Console.ReadLine();
                if (Enum.TryParse(role, out UserRole userRole))
                {
                    switch (userRole)
                    {
                        case UserRole.Администратор:
                            Console.WriteLine("Вы зарегистрированы как Администратор.");
                            break;
                        case UserRole.Модератор:
                            Console.WriteLine("Вы зарегистрированы как Модератор.");
                            break;
                        case UserRole.Пользователь:
                            Console.WriteLine("Вы зарегистрированы как Пользователь.");
                            break;
                        case UserRole.Гость:
                            Console.WriteLine("Вы зарегистрированы как Гость.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: введено некорректное значение. Пожалуйста, введите одну из следующих ролей: Администратор, Модератор, Пользователь, Гость.");
                }
            }
        }
    }
}
