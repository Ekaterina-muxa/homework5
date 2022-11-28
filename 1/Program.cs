// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

void Sqr01 (int N)
{
    for (int i = 1; i<= N; i++)
    {
        Console.WriteLine($"{i} - > {i * i * i}");
    
    }
}
Console.Write ("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());
Sqr01(N);

