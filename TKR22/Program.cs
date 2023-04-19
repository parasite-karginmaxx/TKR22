using System;
namespace TKR22
{
    internal class Program
    {
        static void Main()
        {
            dynamic Theme = new System.Dynamic.ExpandoObject();
            Console.WriteLine("Введите название аудитории: ");
            Theme.Name = Console.ReadLine() ?? @"Тема не указана";


        }
    }
}