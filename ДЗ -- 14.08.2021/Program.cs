using System;

namespace ДЗ____14._08._2021
{
    class Program
    {
        static string ExecuteFirstTask(int elCount)
        {
            int maxEl = 0, minEl = 0, generalSum = 0;
            int[] arr = new int[elCount];
            string oddNumbersStr = "Нечетные числа: ";
        
            for (int i = 0; i < elCount; i++)
            {
                arr[i] = new Random().Next(0, 100);
            }
        
            Array.Sort(arr);
            maxEl = arr[arr.Length - 1];
            minEl = arr[0];
        
            Array.ForEach(arr, item => {
                generalSum += item;
                if(item % 2 == 1)
                {
                    oddNumbersStr += $"-| {item} |-";
                }
            });
        
            return $"Результат: Наибольшее значение массива: {maxEl}\n"+
                   $"Наименьшее значение массива: {minEl}\n"+
                   $"Общую сумму всех элементов: {generalSum}\n"+
                   $"Среднее арифметическое всех элементов: {generalSum / 3}\n"+
                   $"{oddNumbersStr}";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1...");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(ExecuteFirstTask(N));
            
            //Таск 2
            
            static int[] ArrayReverser(int[] arr)  //Новый класс
            {
                int[] reversed = new int[arr.Length];
                for (int i = arr.Length - 1, j = 0; i >= 0 && j < arr.Length ; i--, j++)
                {
                    reversed[j] = arr[i];
                }
                return reversed;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Задание 2...");
                int[] arr = new int[10];
                for(int i = 0; i < 10; i++)
                {
                    arr[i] = new Random().Next(0, 10);
                }
                Console.WriteLine("Элементы Массива:");
                Array.ForEach(arr, item1 => {
                    Console.WriteLine(item1);
                });
                arr = ArrayReverser(arr);
                Console.WriteLine("Инвертированный массив:");
                Array.ForEach(arr, item2 => {
                    Console.WriteLine(item2);
                });
                
                //ТАСК 3
                static void ExecuteThirdTask(int elCount) //Новый класс
                {
                    int[] arr = new int[elCount];
                    for (int i = 0; i < elCount; i++)
                    {
                        arr[i] = new Random().Next(50, 100);
                    }

                    Array.ForEach(arr, item => {
                        Console.WriteLine(item);
                    });

                    Console.Write("Введите (count): ");
                    int count = int.Parse(Console.ReadLine());
                    Console.Write("Введите (index): ");
                    int index = int.Parse(Console.ReadLine());
            
                    int[] arr1 = new int[count];
                    for(int i = 0; i < arr1.Length; i++)
                    {
                        arr1[i] = 1;
                    }
                    for(int i = index, j = 0; j <= count; i++, j++)
                    {
                        try
                        {
                            arr1[j] = arr[i];
                        }
                        catch (IndexOutOfRangeException)
                        {
                            break;
                        }
                    
                    }
            
                    Array.ForEach(arr1, item => {
                        Console.WriteLine(item);
                    });
            
                }

                static void Main(string[] args)
                {
                    Console.WriteLine("Задача 2...");
                    Console.Write("Введите размер массива: ");
                    int elCount = int.Parse(Console.ReadLine());
                    ExecuteThirdTask(elCount);
            
        }
    }
}