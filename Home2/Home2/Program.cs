using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            //Task2();
            //Task3();
            //Task4();
        }

        /*Задание 1

        Напишите программу - консольный калькулятор.
        Создайте две переменные с именами operand1 и operand2.
        Задайте переменным некоторые произвольные значения.
        Предложите пользователю ввести знак арифметической операции.
        Примите значение, введенное пользователем, и поместите его в строковую переменную sign.
        Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch.
        Выведите на экран результат выполнения арифметической операции.
        **В случае использования операции деления, организуйте проверку попытки деления на ноль.
        И если таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке пользователя.
        */

        public static void Task1()
        {
            Console.WriteLine("Please, enter the first number:");
            double operand1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please, enter the second number:");
            double operand2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please, enter operator (+, -, *, /):");
            string sign = Console.ReadLine();
            double result;

            if (operand2 == 0 && sign == "/")
            {
                Console.WriteLine("Division by zero is not allowed!");
            }
            else
            {
                switch (sign)
                {
                    case "+":
                        result = operand1 + operand2;
                        Console.WriteLine($"Result: {result}");
                        break;
                    case "-":
                        result = operand1 - operand2;
                        Console.WriteLine($"Result: {result}");
                        break;
                    case "*":
                        result = operand1 * operand2;
                        Console.WriteLine($"Result: {result}");
                        break;
                    case "/":
                        result = operand1 / operand2;
                        Console.WriteLine($"Result: {result}");
                        break;
                    default:
                        Console.WriteLine("Incorrect operator");
                        break;
                }
            }
        }
        /*Задание 2

        Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в числовой промежуток[0 - 14][15 - 35][36 - 50][50 - 100].
        Если да, то укажите, в какой именно промежуток.
        Если пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков, то выводится соответствующее сообщение.*/

        public static void Task2()
        {
            Console.WriteLine("Please, enter number from 0 to 100:");
            double number = Convert.ToDouble(Console.ReadLine());

            if ((number >= 0) && (number <= 14))
            {
                Console.WriteLine("Your number is between 0 and 14");
            }
            else if ((number >= 15) && (number <= 35))
            {
                Console.WriteLine("Your number is between 15 and 35");
            }
            else if ((number >= 36) && (number <= 50))
            {
                Console.WriteLine("Your number is between 36 and 50");
            }
            else if ((number >= 51) && (number <= 100))
            {
                Console.WriteLine("Your number is between 51 and 100");
            }
            else
            {
                Console.WriteLine("The number doesn't belong to an of the intervals");
            }
        }

        
        /*Задание 3

        Напишите программу русско-английский переводчик.
        Программа знает 10 слов о погоде.
        Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему перевод этого слова на английском языке.
        Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести сообщение, что такого слова нет.*/

        public static void Task3()
        {
            Console.WriteLine("Please, enter a word for translate:");
            string word = Console.ReadLine().ToLower();

            switch (word)
            {
                case "холод":
                    Console.WriteLine("Cold");
                    break;
                case "жара":
                    Console.WriteLine("Heat");
                    break;
                case "ветер":
                    Console.WriteLine("Wind");
                    break;
                case "туман":
                    Console.WriteLine("Fog");
                    break;
                case "дождь":
                    Console.WriteLine("Rain");
                    break;
                case "молния":
                    Console.WriteLine("Lightning");
                    break;
                case "гроза":
                    Console.WriteLine("Thunderstorm");
                    break;
                case "радуга":
                    Console.WriteLine("Rainbow");
                    break;
                case "снег":
                    Console.WriteLine("Snow");
                    break;
                case "слякоть":
                    Console.WriteLine("Slush");
                    break;
                default:
                    Console.WriteLine("Unknown word");
                    break;
            }
        }
        
        
        /*
        Задание 4

        Напишите программу, которая будет выполнять проверку чисел на четность.*/

        public static void Task4()
        {
            Console.WriteLine("Please, enter any number:");
            int number = Convert.ToInt32(Console.ReadLine());

            //Число - четное
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is even");
            }

            //Число - нечетное
            else
            {
                Console.WriteLine($"The number {number} is odd");
            }
        }
    }
}