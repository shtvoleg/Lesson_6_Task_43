// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();                                                  //  очистка консоли
Console.WriteLine("Введите B1=");    //  ввод числа
float b1 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Введите K1=");    //  ввод числа
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B2=");    //  ввод числа
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите K2=");    //  ввод числа
int k2 = Convert.ToInt32(Console.ReadLine());

float x, y;
if (k1 == k2)                                                     // если отрицательное значение
    Console.WriteLine($"Прямые параллельны.");
else
    {
    x=(b2-b1)/(k1-k2);
    y=k1*x + b1;
    Console.WriteLine($"Точка пересечения прямых: ({string.Format("{0:f2}", x)},{string.Format("{0:f2}", y)}).");
    }