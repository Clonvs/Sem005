// Задача 34: Задайте массив 
//заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

// int []arr = new int [8];
// int k = 0;
// Random rnd = new Random();
// Console.WriteLine("исходный массив");
// for (int i = 0; i < 8; i++)
// {Console.Write("[");
//     arr [i]= rnd.Next(100, 999);
//     Console.Write("{0} ", arr[i]+"]");
// } 
//Console.WriteLine();
// Console.WriteLine("Отсортированный массив");
// Array.Sort(arr);
// foreach (int element in arr)
// {
//     Console.Write("{0} ","[" + element + "]"  );
//     if (element % 2==0)
//     {
//         k++;
        
//     }
// }
//Console.WriteLine();
// Console.Write($" -> {k} ");

//Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// double[]array = {3.5,7.1,22.9,2.3,78.5};
// void PrintArr(double[]arr)
// {
// for (int i = 0; i < arr.Length; i++)
// {
//     if(i==0)
// Console.Write("[");
// if (i < arr.Length - 1)
// Console.Write(arr[i] + ",");
// else
// Console.Write(arr[i]+"]");    

// }
// }
// double Max (double[]arr)
// {
// double max = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i]>max)
// max = arr[i];
// }
// return max;
// }

// double Min(double[]arr)
// {
// double min = arr[0];
// for (int i = 0; i < arr.Length; i++)
// {
//     if(arr[i]<min)
//     min = arr[i];
// }
// return min;
// }
// Console.Write("Исходный масив");
// PrintArr(array);
// Console.WriteLine();
// double resMin = Min(array);
// double resMax = Max(array);
// double resault = resMax - resMin;
// Console.Write($"Разница между максимальным и минимальным значениями массива:{resault}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.

// int []arr = new int [8];
// int k = 0,sum = 0;
// Random rnd = new Random();
// Console.WriteLine("исходный массив");
// for (int i = 0; i < 8; i++)
// {Console.Write("[");
//     arr [i]= rnd.Next(1, 100);
//     Console.Write("{0} ", arr[i]+"]");
// } 
// Console.WriteLine();
// Console.WriteLine("Отсортированный массив");
// Array.Sort(arr);

// foreach (int element in arr)
// {
//     Console.Write("{0} ","[" + element + "]"  );
//     if (element % 2 == 1)
//     {   
//         k=k+1;
//         sum+=element;
//     }
// }
// Console.WriteLine();
// Console.Write($"{sum}");