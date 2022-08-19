//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

/*
string Palindrome(string massiv)
{
    string palin = "not a palindrome";
    if (massiv[0] == massiv[4]) 
        {
        if (massiv[1] == massiv[3])
            palin = "a palindrome";
        }
    return palin;
}

Console.Write("Please input your number: ");
string digit = Console.ReadLine();

Console.Write($"Your number {digit} is {Palindrome(digit)}");
*/

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double Distance(int[] dot1, int[] dot2)
{
    double[] distdot = new double[3];
    for (int i = 0; i < 3; i++)
    {
        distdot[i] = (dot2[i] - dot1[i]) * (dot2[i] - dot1[i]);
        //Console.WriteLine(distdot[i]);
    }
    double dist = Math.Sqrt(distdot[0] + distdot[1] + distdot[2]);
    return dist;
}

Console.WriteLine("Please input coordinates of the first dot: ");
int[] dot1 = new int[3];
Console.Write("Please input X of the first dot: ");
dot1[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input Y of the first dot: ");
dot1[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input Z of the first dot: ");
dot1[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input coordinates of the second dot: ");
int[] dot2 = new int[3];
Console.Write("Please input X of the second dot: ");
dot2[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input Y of the second dot: ");
dot2[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input Z of the second dot: ");
dot2[2] = Convert.ToInt32(Console.ReadLine());

Console.Write($"The distance between two dots is: {Distance(dot1, dot2)}");
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