/* Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N. (3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125) */

void cube()
{
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    for (int i = 1; i <= num; i++)
    {
        int a = i * i * i;
        Console.WriteLine(a);
    }
}
cube();