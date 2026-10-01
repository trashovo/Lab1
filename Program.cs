using System;

namespace Lab
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Tasks tasks = new Tasks();

            Console.WriteLine("Выберите номер задания:");
            Console.WriteLine("1. Задание 1");
            Console.WriteLine("2. Задание 2");
            Console.WriteLine("3. Задание 3");

            Console.Write("\nВведите номер задания: ");
            int taskgroup = int.Parse(Console.ReadLine());

            while (taskgroup < 1 || taskgroup > 3)
            {
                Console.Write("Ошибка, введите номер задания от 1 до 3: ");
                taskgroup = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            switch (taskgroup)
            {
                case 1:
                {
                    Console.WriteLine("1. Дробная часть");
                    Console.WriteLine("2. Букву в число");
                    Console.WriteLine("3. Двузначное");
                    Console.WriteLine("4. Диапазон");
                    Console.WriteLine("5. Равенство");

                    Console.Write("\nВыберите номер задачи: ");
                    int choice = int.Parse(Console.ReadLine());

                    while (choice < 1 || choice > 5)
                    {
                        Console.Write("Ошибка, введите номер задачи от 1 до 5: ");
                        choice = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine();

                    switch (choice)
                    {
                        case 1:
                        {
                            Console.Write("Введите вещественное число x: ");
                            double x = double.Parse(Console.ReadLine());
                            double result = tasks.fraction(x);
                            Console.WriteLine($"Результат: {result}");
                            break;
                        }
                        case 2:
                        {
                            Console.Write("Введите символ (0-9): ");
                            char x = char.Parse(Console.ReadLine());

                            while (x < '0' || x > '9')
                            {
                                Console.Write("Ошибка, введите символ от 0 до 9: ");
                                x = char.Parse(Console.ReadLine());
                            }

                            int result = tasks.charToNum(x);
                            Console.WriteLine($"Результат: {result}");
                            break;
                        }
                        case 3:
                        {
                            Console.Write("Введите целое число x: ");
                            int x = int.Parse(Console.ReadLine());
                            bool result = tasks.is2Digits(x);
                            Console.WriteLine($"Результат: {result}");
                            break;
                        }
                        case 4:
                        {
                            Console.Write("Введите целое число a: ");
                            int a = int.Parse(Console.ReadLine());
                            Console.Write("Введите целое число b: ");
                            int b = int.Parse(Console.ReadLine());
                            Console.Write("Введите целое число num: ");
                            int num = int.Parse(Console.ReadLine());
                            bool result = tasks.isInRange(a, b, num);
                            Console.WriteLine($"Результат: {result}");
                            break;
                        }
                        case 5:
                        {
                            Console.Write("Введите целое число a: ");
                            int a = int.Parse(Console.ReadLine());
                            Console.Write("Введите целое число b: ");
                            int b = int.Parse(Console.ReadLine());
                            Console.Write("Введите целое число c: ");
                            int c = int.Parse(Console.ReadLine());
                            bool result = tasks.isEqual(a, b, c);
                            Console.WriteLine($"Результат: {result}");
                            break;
                        }
                    }

                    break;
                }

                case 2:
                {
                    Console.WriteLine("1. Модуль числа");
                    Console.WriteLine("2. Тридцать пять");
                    Console.WriteLine("3. Тройной максимум");
                    Console.WriteLine("4. Двойная сумма");
                    Console.WriteLine("5. День недели");

                    Console.Write("\nВыберите номер задачи: ");
                    int choice = int.Parse(Console.ReadLine());

                    while (choice < 1 || choice > 5)
                    {
                        Console.Write("Ошибка, введите номер задачи от 1 до 5: ");
                        choice = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine();

                    switch (choice)
                    {
                        case 1:
                        {
                            Console.Write("Введите целое число x: ");
                            int x = int.Parse(Console.ReadLine());
                            int result = tasks.abs(x);
                            Console.WriteLine($"Результат: {result}");
                            break;
                        }
                        case 2:
                        {
                            Console.Write("Введите целое число x: ");
                            int x = int.Parse(Console.ReadLine());
                            bool result = tasks.is35(x);
                            Console.WriteLine($"Результат: {result}");
                            break;
                        }
                        case 3:
                        {
                            Console.Write("Введите целое число x: ");
                            int x = int.Parse(Console.ReadLine());
                            Console.Write("Введите целое число y: ");
                            int y = int.Parse(Console.ReadLine());
                            Console.Write("Введите целое число z: ");
                            int z = int.Parse(Console.ReadLine());
                            int result = tasks.max3(x, y, z);
                            Console.WriteLine($"Результат: {result}");
                            break;
                        }
                        case 4:
                        {
                            Console.Write("Введите целое число x: ");
                            int x = int.Parse(Console.ReadLine());
                            Console.Write("Введите целое число y: ");
                            int y = int.Parse(Console.ReadLine());
                            int result = tasks.sum2(x, y);
                            Console.WriteLine($"Результат: {result}");
                            break;
                        }
                        case 5:
                        {
                            Console.Write("Введите номер дня недели: ");
                            int x = int.Parse(Console.ReadLine());
                            string result = tasks.day(x);
                            Console.WriteLine($"Результат: {result}");
                            break;
                        }
                    }

                    break;
                }

                case 3:
                {
                    Console.WriteLine("1. Числа подряд");
                    Console.WriteLine("2. Четные числа");
                    Console.WriteLine("3. Длина числа");
                    Console.WriteLine("4. Квадрат");
                    Console.WriteLine("5. Правый треугольник");

                    Console.Write("\nВыберите номер задачи: ");
                    int choice = int.Parse(Console.ReadLine());

                    while (choice < 1 || choice > 5)
                    {
                        Console.Write("Ошибка, введите номер задачи от 1 до 5: ");
                        choice = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine();

                    switch (choice)
                    {
                        case 1:
                        {
                            Console.Write("Введите неотрицательное целое число x: ");
                            int x = int.Parse(Console.ReadLine());

                            while (x < 0)
                            {
                                Console.Write("Ошибка, введите число больше или равное 0: ");
                                x = int.Parse(Console.ReadLine());
                            }

                            string result = tasks.listNums(x);
                            Console.WriteLine($"Результат: {result}");
                            break;
                        }
                        case 2:
                        {
                            Console.Write("Введите неотрицательное целое число x: ");
                            int x = int.Parse(Console.ReadLine());

                            while (x < 0)
                            {
                                Console.Write("Ошибка, введите число больше или равное 0: ");
                                x = int.Parse(Console.ReadLine());
                            }

                            string result = tasks.chet(x);
                            Console.WriteLine($"Результат: {result}");
                            break;
                        }
                        case 3:
                        {
                            Console.Write("Введите целое число x: ");
                            long x = long.Parse(Console.ReadLine());
                            int result = tasks.numLen(x);
                            Console.WriteLine($"Результат: {result}");
                            break;
                        }
                        case 4:
                        {
                            Console.Write("Введите неотрицательное целое число x: ");
                            int x = int.Parse(Console.ReadLine());

                            while (x <= 0)
                            {
                                Console.Write("Ошибка, введите число больше 0: ");
                                x = int.Parse(Console.ReadLine());
                            }

                            Console.WriteLine("Результат:");
                            tasks.square(x);
                            break;
                        }
                        case 5:
                        {
                            Console.Write("Введите неотрицательное целое число x: ");
                            int x = int.Parse(Console.ReadLine());

                            while (x <= 0)
                            {
                                Console.Write("Ошибка, введите число больше 0: ");
                                x = int.Parse(Console.ReadLine());
                            }

                            Console.WriteLine("Результат:");
                            tasks.rightTriangle(x);
                            break;
                        }
                    }

                    break;
                }
            }
        }
    }
}