using CodeBlogFitness.BL.Controller;
using System;

namespace CodeBlogFitness.CMD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует прилодение CodeBlogDitness");

            Console.WriteLine("Введите имя пользователя:");
            var name = Console.ReadLine();

            Console.WriteLine("Введите пол:");
            var gender = Console.ReadLine();

            Console.WriteLine("Введите дату рождения:");
            var birthdate = DateTime.Parse(Console.ReadLine()); //TODY: Переписать

            Console.WriteLine("Введите вес:");
            var weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост:");
            var height = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthdate, weight, height);
            userController.Save();
        }
    }
}
