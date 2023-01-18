// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.WriteLine("Массив: ");
//int count= new Random().Next(1,10); - рандомное кол-во элементов не получилось ввести
int[] array = new int[10];
int result=0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write($"{array[i]} ");
    
    if (array[i] % 2 == 0)
    {
        result++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел: {result}");

