//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
/*
int ThreeDigit(int thrdg)
{
    int twodigit = (thrdg / 10) % 10;
    return decim;
}

Console.Write("Please input threedigit number ");
int number = (Convert.ToInt32(Console.ReadLine()));

Console.Write($"The second digit of {number} is {ThreeDigit(number)}");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
/*
int ThirdDig(int bigNumber)
{
   int thrdg = (bigNumber % 10) % 10;
   return thrdg;
}

Console.Write("Please input any number ");
int number = (Convert.ToInt32(Console.ReadLine()));

if (number > 100) Console.Write($"The third digit of {number} is {ThirdDig(number)}");
else Console.Write($"Number {number} doesn't have the third digit");
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
/*
string WeekNum(int holy)
{
    string dayy;
    if (holy <=7)
        if (holy == 6 || holy == 7) 
            dayy = "a weekend";
        else dayy = "not a weekend";
    else dayy = "not a week's day at all";
    return dayy;
}

Console.Write("Please input any weekday's number ");
int number = (Convert.ToInt32(Console.ReadLine()));
Console.Write($"The {number} day of week is {WeekNum(number)}");
*/