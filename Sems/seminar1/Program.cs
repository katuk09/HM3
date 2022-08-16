//Task1
/*
int num, square;

Console.WriteLine("Hi, beauty!");

Console.Write("Input your number: ");

num = Convert.ToInt32(Console.ReadLine());

square = num * num;

Console.WriteLine("Square number of " + num + " is " + square);

Console.WriteLine($"Square number of {num} is {square}");
*/

//Task 2 Программа, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*
int num1, num2, sq;

Console.Write("Input 1st number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input 2nd number: ");
num2 = Convert.ToInt32(Console.ReadLine());

sq = num2 * num2;

if (num1 == sq)
{  // можно опустить скобки, если одно действие, как тут
    Console.WriteLine($"{num1} is a square of {num2}");
}
else
{
    Console.WriteLine($"{num1} is not a square of {num2}");
}

*/

// Задача 3. Написать программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.Write("Input 1st number: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = num * (-1);

while (i <= num)
{
    Console.Write(i + " ");
    i++;
}
*/

// Задача 4. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
/*
Console.Write("Input 3digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int ed = num % 10;
Console.Write($"Last digit of {num} is {ed}");
*/