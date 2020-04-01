using System;

namespace SixthHw
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter size of new array: ");
            int n = int.Parse(Console.ReadLine()), maxValue, minValue, cont, i, j;
            double sum = 0;
            int [] arr = new int [n];
            for ( i = 0; i < arr.Length; i ++){
                    arr [i] = new Random().Next(20);
                    Console.Write($"{arr[i]}  ");
                }
            System.Console.WriteLine("");
            maxValue = arr [0];
            minValue = arr [0];
            for ( i = 0; i < arr.Length; i ++){
                    if (arr [i] >= maxValue)
                         maxValue = arr[i];
                    if (arr [i] <= minValue)
                         minValue = arr[i];
                    sum += arr [i];
                    if (arr [i] % 2 != 0)
                         Console.WriteLine($"odd number in the array: {arr[i]}");
            }
            double average = sum / n;
            Console.WriteLine($"Max = {maxValue}, min = {minValue}, sum = {sum},  average = {average}");
            

            //second
            for ( i = 0; i < (arr.Length / 2); i ++){
                    cont = arr[i];
                    arr[i] = arr[n-i-1];
                    arr[n - i - 1] = cont;
            }
            System.Console.Write("Inverted array: ");
            for ( i = 0; i < arr.Length; i ++)
                    Console.Write($"{arr[i]}  ");


            //third
            System.Console.Write("\nEnter size of new array: ");
            n = int.Parse(Console.ReadLine());
            int [] arr2 = new int [n];
            for ( i = 0; i < arr2.Length; i ++){
                    arr2 [i] = new Random().Next(20);
                    Console.Write($"{arr2[i]}  ");
                }
            System.Console.Write($"\nFrom what position would you like to trim this array?((0-{n-1})) ");
            int index = int.Parse(Console.ReadLine());
            System.Console.Write("How many array elements do you want to cut? ");
            int count = int.Parse(Console.ReadLine());
            int [] newArray = new int [count];
                for (i = index, j = 0; i < (count + index); i++, j++){
                    if (i >= n)
                        newArray[j] = 1;
                    else
                        newArray[j] = arr2[i];
                }
            System.Console.Write("new array: ");
            for ( i = 0; i < newArray.Length; i ++)
                    Console.Write($"{newArray[i]}  ");
            Console.ReadKey();
        }
    }
}
