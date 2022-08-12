//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Enter your number");
int number = Convert.ToInt32(Console.ReadLine());

string Palind(int number)
{
    string str = number.ToString();
    if (str[0] == str[str.Length - 1] && str[1] == str[str.Length - 2])
    {
        return "Yes";
    }
    else
    {
        return "No";
    }
}

Console.WriteLine(Palind(number)); 

//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double Long(int x1, int y1, int z1, int x2,  int y2,  int z2) 
{
   return Math.Round(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)), 2);
}

Console.WriteLine(Long(3, 6, 8, 2, 1, -7));
Console.WriteLine(Long(7, -5, 0, 1, -1, 9));

//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Enter your number N");
int N = Convert.ToInt32(Console.ReadLine());

void Сube(int N) 
{
    for (int i = 1; i <= N; i++)
    {
        Console.Write("{0}, ", i * i * i);
    }
}

Сube(N);