// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Массив: ");

double[] array = new double[5];
double result = 0;

Random random_number = new Random();


for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round((random_number.NextDouble() * random_number.Next(0,100)), 1);
    Console.Write(array[i] + " ");
}
double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (max < array[i])
    {
        max = array[i];
    
    }
       if (min > array[i])
    {
        min = array[i];
    
    }
}

result = (max - min);
Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным элементов массива: " + max + " - " + min + " = " + result);