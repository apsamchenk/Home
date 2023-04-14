using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }

        /// <summary>
        /// Задать строку содержащую внутри цифры и несколько повторений слова test, Заменить в строке все вхождения 'test' на 'testing'.
        /// </summary>

        public static void Task1()
        {
            string str = "12test54353testtest23424test1";
            Console.WriteLine($"Old string: {str}");

            string newStr = str.Replace("test", "testing");
            Console.WriteLine($"New string: {newStr}");
        }

        /// <summary>
        /// Создайте переменные, которые будут хранить следующие слова: (Welcome, to, the, TMS, lessons)выполните конкатенацию слов и выведите на экран следующую фразу:
        /// Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". Не забывайте о пробелах после каждого слова
        /// </summary>

        public static void Task2()
        {
            string str1 = "Welcome";
            string str2 = "to";
            string str3 = "the";
            string str4 = "TMS";
            string str5 = "lessons";

            string newString = $"\"{str1}\" " + $"\"{str2}\" " + $"\"{str3}\" " + $"\"{str4}\" " + $"\"{str5}\"";
            Console.WriteLine(newString);
        }

        /// <summary>
        /// Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
        /// Необходимо найти в данной строке "abc", записав всё что до этих символов в переменную firstPart, а также всё, что после них во вторую secondPart.
        /// </summary>

        public static void Task3()
        {
            string str = "teamwithsomeofexcersicesabcwanttomakeitbetter";

            int index = str.IndexOf("abc");

            string firstPart = str.Substring(0, index);
            Console.WriteLine("First part: " + firstPart);

            string secondPart = str.Substring(index + 3, str.Length - firstPart.Length - 3);
            Console.WriteLine("Second part: " + secondPart);
        }

        /// <summary>
        /// Дана строка: Good day. Необходимо с помощью метода substring удалить слово "Good". После чего необходимо используя команду insert создать строку со значением: The best day!!!!!!!!!.
        /// Заменить последний "!" на "?" и вывести результат на консоль. 
        /// </summary>

        public static void Task4() 
        {
            string str = "Good day";

            int index = str.IndexOf('d');

            string subStr = str.Substring(index + 1, str.Length - index - 1);

            string insStr = subStr.Insert(0, "The best");

            string insStr2 = insStr.Insert(insStr.Length, "!!!!!!!!!");

            int index2 = insStr2.LastIndexOf('!');

            string result = insStr2.Remove(index2).Insert(index2, "?");
            Console.WriteLine(result);
        }
    }
}