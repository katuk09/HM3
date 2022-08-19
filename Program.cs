//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
/*
int[] FillingArray(string number)
{
    int[] array = new int[number.Length];
    for (int i = 1; i <= number.Length; i++)
        {
        array[i] = Convert.ToInt32(number[i]);
        Console.Write(array[i]);
        }
    return array;
}

string Palindrome(int[] massiv)
{
    string palin = "not a palindrome";
    if (massiv[1] == massiv[5]) 
        {
        if (massiv[2] == massiv[4])
            palin = "a palindrome";
        }
    return palin;
}

Console.Write("Please input your number: ");
string str;
str = Console.ReadLine();

Console.Write($"Your number {FillingArray(str)} is {Palindrome(FillingArray(str))}");

*/

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/*double Distance()

double dist = 

Console.Write("Please input coordinates of the first dot: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please input coordinates of the second dot: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());
*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
/*
void CubeCube(int num)
{
    int cuby = 1;
    for (int i = 1; i <= num; i++)
    {
        cuby = i * i * i;
        Console.Write($"{cuby} -> ");
        cuby = 1;
    }
}

Console.Write("Please input any number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Here is the list of cubes of numbers from 1 to {number}");
CubeCube(number);
*/