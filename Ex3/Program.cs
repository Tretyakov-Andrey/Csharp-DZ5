// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double [10];
double diff = 0 , min = 100, max = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next (0, 100);
    System.Console.Write(array[i] + " ");
    if (max < array[i]) max = array[i];
    if (min > array[i]) min = array[i];
}

diff = max - min;

System.Console.WriteLine();
System.Console.WriteLine(max);
System.Console.WriteLine(min);
System.Console.WriteLine("Разница = " + diff);
