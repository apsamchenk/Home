using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task0();
            //Task1();
            //Task2();
            //Task3();
            //Task4();
        }

        /*Создайте массив целых чисел. Напишете программу, которая выводит сообщение о том, входит ли заданное число в массив или нет. Пусть число для поиска задается с консоли.*/
        public static void Task0()
        {
            Random random = new Random();

            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)random.Next(1, 9);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\nPlease, enter your number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool flag = false;

            foreach (int i in array)
            {
                if (i == number)
                {
                    flag = true;
                }
            }

            if (flag == true)
            {
                Console.WriteLine("The number belongs to the array"); //Заданное  число входит в массив
            }
            else
            {
                Console.WriteLine("The number doesn't belong to the array"); //Заданное число НЕ входит в массив
            }
        }

        /*Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение.  
        Для генерации случайного числа используйте метод Random() .  Пусть будет возможность создавать массив произвольного размера.  Пусть размер массива вводится с консоли.  */

        public static void Task2()
        {
            Random random = new Random();

            Console.WriteLine("Please, enter array size: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)random.Next(10);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\nMax value: " + array.Max());
            Console.WriteLine("Min value: " + array.Min());
            Console.WriteLine("Average value: " + array.Average());
        }

        /*Создайте 2 массива из 5 чисел.  
        Выведите массивы на консоль в двух отдельных строках.  
        Посчитайте среднее арифметическое элементов каждого массива и сообщите, для какого из массивов это значение оказалось больше (либо сообщите, что их средние арифметические равны).  */

        public static void Task3()
        {
            Random random = new Random();

            int[] array1 = new int[5];
            int[] array2 = new int[5];

            Console.Write("First array: ");

            for (int i = 0; i < array1.Length; i++) //Наполнение первого массива
            {
                array1[i] = (int)random.Next(10);
                Console.Write(array1[i] + " ");
            }

            Console.WriteLine("");

            Console.Write("Second array: ");

            for (int i = 0; i < array2.Length; i++) //Наполнение второго массива
            {
                array2[i] = (int)random.Next(10);
                Console.Write(array2[i] + " ");
            }

            Console.WriteLine("\n\nAverage value for First array: " + array1.Average());
            Console.WriteLine("Average value for Second array: " + array2.Average());

            if (array1.Average() > array2.Average())
            {
                Console.WriteLine("\nAverage value for First array is bigger");
            }

            else if (array1.Average() < array2.Average())
            {
                Console.WriteLine("\nAverage value for Second array is bigger");
            }

            else
            {
                Console.WriteLine("\nAverage values are equal");
            }
        }

        /*Создайте массив и заполните массив.  
        Выведите массив на экран в строку.  
        Замените каждый элемент с нечётным индексом на ноль.  
        Снова выведете массив на экран на отдельной строке. */

        public static void Task4()
        {
            Random random = new Random();

            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)random.Next(1, 9);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    array[i] = 0;
                }

                Console.Write(array[i] + " ");
            }
        }
    }


}