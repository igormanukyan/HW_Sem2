// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// void numMultiple(int num)
// {
//     if (num % 7 == 0 && num % 23 == 0)
//     {
//         System.Console.WriteLine($"Число {num} кратно 7 и 23");
//     }
//     else
//     {
//         System.Console.WriteLine($"Число не кратно");
//     }
// }

// System.Console.WriteLine("Input number ");
// int number = Convert.ToInt32(Console.ReadLine());
//  numMultiple (number);


// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.


// void coordQuarter (int x, int y)
// {
//     if (x > 0 && y > 0)
//     {
//         System.Console.WriteLine($"I четвярть");
//     }
//     if (x < 0 && y > 0)
//     {
//         System.Console.WriteLine($"II четвярть");
//     }
//     if (x < 0 && y < 0)
//     {
//         System.Console.WriteLine($"III четвярть");
//     }
//     if (x > 0 && y < 0)
//     {
//         System.Console.WriteLine($"IV четвярть");
//     }
    
// }

// System.Console.WriteLine("Input cord (x)");
// int cord_x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input cord (y)");
// int cord_y = Convert.ToInt32(Console.ReadLine());

// coordQuarter (cord_x, cord_y);


// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
// class Program {
// static void Main() {
// Console.Write("Введите число из отрезка [10, 99]: "); int number = Convert.ToInt32(Console.ReadLine());
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine(maxDigit); }
// }

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
// class Program
// {
// static void Main() {
// Console.Write("Введите натуральное число N: "); int N = Convert.ToInt32(Console.ReadLine());
// if (N < 10) {
// Console.WriteLine(N); }
// else {
// while (N > 0) {
// int currentDigit = N % 10; N /= 10;
// if (N > 0)
// {
// Console.Write(currentDigit + ","); }
// else {
// Console.WriteLine(currentDigit); }
// } }
// } }