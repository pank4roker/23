using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Gender {Мужской,Женский }
    class Student
    {
       public string FIO { get; set; }
       public int YearOfBirth { get; set; }
       public Gender Genders { get; set; }
       public Student(string fIO, int yearOfBirth, Gender genders)
       {
            FIO = fIO;
            YearOfBirth = yearOfBirth;
            Genders = genders;
       }
       public void OutPut()
       {
            Console.WriteLine($"{FIO};{YearOfBirth};{Genders}");
       }
        public static void OutPuts(List<Student> students) 
        { 
            foreach(var student in students)
            {
                student.OutPut();
            }
        }
       public static void OutPutGender(List<Student> students) 
       {
            Console.WriteLine("Список студентов мужского пола:");
            foreach (var student in students)
            {
                if (student.Genders == Gender.Мужской)
                {
                    student.OutPut();
                }
            }

            Console.WriteLine("Список студентов женского пола:");
            foreach (var student in students)
            {
                if (student.Genders == Gender.Женский)
                {
                    student.OutPut();
                }
            }
        }
       public static Student InPut()
       {
                Console.Write("Введите ФИО студента(Фамилия И.О.): ");
                string fio = Console.ReadLine();
                Console.Write("Введите год рождения студента: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите пол (0 мужской, 1 женский): ");
                int genderInput = Convert.ToInt32(Console.ReadLine());
                Gender gender = (Gender)genderInput;
                return new Student(fio, year, gender);
        }

    }
}