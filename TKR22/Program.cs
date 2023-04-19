using System;
namespace TKR22
{
    internal class Program
    {
        static void Main()
        {
            #region Объект 1
            dynamic Theme = new System.Dynamic.ExpandoObject();
            Console.WriteLine("Введите название аудитории: ");
            Theme.Name = Console.ReadLine() ?? @"Тема не указана";
            #endregion

            #region Объект 2
            dynamic Paragraph = new System.Dynamic.ExpandoObject();
            Console.WriteLine("Введите название параграфа: ");
            Paragraph.Name = Console.ReadLine() ?? @"Название паарграфа не указано";
            Paragraph.Theme = Theme;
            #endregion

            #region Объект 3
            dynamic LessonType = new System.Dynamic.ExpandoObject();
            dynamic TopicOfLessonType = new System.Dynamic.ExpandoObject();
            Console.WriteLine("Введите кол-во часов: ");
            TopicOfLessonType.Name = Console.ReadLine() ?? @"Кол-во часов не указано";
            TopicOfLessonType.Theme = Theme;
            TopicOfLessonType.LessonType = LessonType;
            #endregion

            #region Объект 4
            dynamic Material = new System.Dynamic.ExpandoObject();
            Console.WriteLine("Введите название учебного материала: ");
            Material.Name = Console.ReadLine() ?? @"Название не указано";
            Console.WriteLine("Введите имя автора: ");
            Material.Author = Console.ReadLine() ?? @"Имя автора не указано";
            #endregion
        }
    }
}