using System;

namespace semzaganiipoyazikamprogrammirovaniy
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double x, y, sum, percent, operation;
                Console.WriteLine("Введите номер заданиия");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number >= 1 && number <= 7) { }
                else
                {
                    Console.WriteLine("Ошибка");
                }
                switch (number)
                {

                    case 1:
                        Console.WriteLine("УПРАЖНЕНИЕ 1. Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа. А программа сранивает два введенных числа и выводит на консоль результат сравнения (два числа равны, первое число больше второго или первое число меньше второго).");
                        Console.WriteLine("Введите первое число:");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число:");
                        y = Convert.ToInt32(Console.ReadLine());

                        if (x > y)
                        {
                            Console.WriteLine("Первое число больше второго");
                        }
                        else if (x < y)
                        {
                            Console.WriteLine("Первое число меньше второго");
                        }
                        else
                        {
                            Console.WriteLine("Оба числа равны");
                        }
                        break;
                    case 2:
                        Console.WriteLine("УПРАЖНЕНИЕ 2. Напишите консольную программу, в которую пользователь вводит с клавиатуры число. Если число одновременно больше 5 и меньше 10, то программа выводит 'Число больше 5 и меньше 10'. Иначе программа выводит сообщение 'Неизвестное число'.");
                        Console.WriteLine("Введите число:");
                        x = Convert.ToInt32(Console.ReadLine());

                        if (x > 5 && x < 10)
                        {
                            Console.WriteLine("Число больше 5 и меньше 10");
                        }
                        else
                        {
                            Console.WriteLine("Неизвестное число");
                        }
                        break;
                    case 3:
                        Console.WriteLine("УПРАЖНЕНИЕ 3. Напишите консольную программу, в которую пользователь вводит с клавиатуры число. Если число либо равно 5, либо равно 10, то программа выводит 'Число либо равно 5, либо равно 10'. Иначе программа выводит сообщение 'Неизвестное число'.");
                        Console.WriteLine("Введите число:");
                        x = Convert.ToInt32(Console.ReadLine());

                        if (x == 5 || x == 10)
                        {
                            Console.WriteLine("Число либо равно 5, либо равно 10");
                        }
                        else
                        {
                            Console.WriteLine("Неизвестное число");
                        }
                        break;
                    case 4:
                        Console.WriteLine("УПРАЖНЕНИЕ 4. В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться. Напишите консольную программу, в которую пользователь вводит сумму вклада. Если сумма вклада меньше 100, то начисляется 5%. Если сумма вклада от 100 до 200, то начисляется 7%. Если сумма вклада больше 200, то начисляется 10%. В конце программа должна выводить сумму вклада с начисленными процентами.");
                        Console.WriteLine("Введите сумму вклада:");
                        sum = Convert.ToDouble(Console.ReadLine());

                        if (sum < 100)
                        {
                            sum += sum * 0.05;
                        }
                        else if (sum <= 200)
                        {
                            sum += sum * 0.07;
                        }
                        else
                        {
                            sum += sum * 0.1;
                        }
                        Console.WriteLine($"Сумму вклада после начисления процентов: {sum}");
                        break;
                    case 5:
                        Console.WriteLine("УПРАЖНЕНИЕ 5. Изменим предыдущую задачу. Допустим, банк периодически начисляет по всем вкладам кроме процентов бонусы. И, допустим, сейчас банк решил доначислить по всем вкладам 15 единиц вне зависимости от их суммы. Измените программу таким образом, чтобы к финальной сумме дочислялись бонусы.");
                        Console.WriteLine("Введите сумму вклада:");
                        sum = Convert.ToDouble(Console.ReadLine());
                        percent = 0;
                        if (sum < 100)
                        {
                            percent = 0.05;
                        }
                        else if (sum <= 200)
                        {
                            percent = 0.07;
                        }
                        else
                        {
                            percent = 0.1;
                        }
                        sum += sum * percent + 15;

                        Console.WriteLine($"Сумму вклада после начисления процентов: {sum}");
                        break;
                    case 6:
                        Console.WriteLine("УПРАЖНЕНИЕ 6. Напишите консольную программу, которая выводит пользователю сообщение 'Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение'. Рядом с названием каждой операции указан ее номер, например, операция вычитания имеет номер 2. Пусть пользователь вводит в программу номер операции, и в зависимости от номера операции программа выводит ему название операции.");
                        Console.WriteLine("Для определения операции по введенному номеру используйте конструкцию switch...case.");
                        Console.WriteLine("Если введенное пользователем число не соответствует никакой операции(например, число 120), то выведите пользователю сообщение о том, что операция неопределена.");
                        Console.WriteLine("Введите номер операции:\n1.Сложение\n2.Вычитание\n3.Умножение");

                        operation = Convert.ToInt32(Console.ReadLine());
                        switch (operation)
                        {
                            case 1:
                                Console.WriteLine("\nСложение");
                                break;
                            case 2:
                                Console.WriteLine("\nВычитание");
                                break;
                            case 3:
                                Console.WriteLine("\nУмножение");
                                break;
                            default:
                                Console.WriteLine("\nНеизвестная операция");
                                break;
                        }
                        break;
                    case 7:
                        Console.WriteLine();
                        Console.WriteLine("Введите номер операции:\n1.Сложение\n2.Вычитание\n3.Умножение");

                        operation = Convert.ToInt32(Console.ReadLine());
                        switch (operation)
                        {
                            case 1:
                                Console.WriteLine("\nСложение");
                                Console.WriteLine("Введите два числа, которые хотите сложить:");
                                x = Convert.ToDouble(Console.ReadLine());
                                y = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"\nОтвет: {x + y}");
                                break;
                            case 2:
                                Console.WriteLine("\nВычитание");
                                Console.WriteLine("Введите два числа, которые хотите вычтать:");
                                x = Convert.ToDouble(Console.ReadLine());
                                y = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"\nОтвет: {x - y}");
                                break;
                            case 3:
                                Console.WriteLine("\nУмножение");
                                Console.WriteLine("Введите два числа, которые хотите умножить:");
                                x = Convert.ToDouble(Console.ReadLine());
                                y = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"\nОтвет: {x * y}");
                                break;
                            default:
                                Console.WriteLine("Ошибка");
                                break;
                        }
                        break;
                }
    }
        }
    }
}
