// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через пробел: ");
int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int sum = 0;
for (int i=0; i<a.Length; i++)
{
    if (a[i]>0)
    {
        sum = sum + 1;
    }
}
Console.WriteLine($"{sum} элементов больше нуля");
