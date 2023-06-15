using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    enum Color
    {
        red = 0,
        white= 1,
        blue =2
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 0, 2, 1, 1, 0 };
            int[] arr2 = new int[] { 2,0,1 };
            // Array.Sort(arr); Как было бы прекрасно
            // Array.Sort(arr2); Как было бы прекрасно #2
            
            // arr ориторовка 
            int buffer;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        buffer = arr[i];
                        arr[i] = arr[j];
                        arr[j] = buffer;
                    }
                }
            }
            //
            // arr2 ориторовка 
            for (int i = 0; i < arr2.Length - 1; i++)
            {
                for (int j = i + 1; j < arr2.Length; j++)
                {
                    if (arr2[i] > arr2[j])
                    {
                        buffer = arr2[i];
                        arr2[i] = arr2[j];
                        arr2[j] = buffer;
                    }
                }
            }
            //

            foreach (var item in arr)
            {
                Console.Write(item+"\t");
            }
            Console.WriteLine();
            foreach (var item in arr2)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
            foreach(var item in arr)
            {
                switch (item)
                {
                   case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(item + "\t");
                        break;
                   case 1:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(item + "\t");
                        break;
                   case 2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(item + "\t");
                        break;
                }
            }
            Console.WriteLine();
            foreach (var item in arr2)
            {
                switch (item)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(item + "\t");
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(item + "\t");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(item + "\t");
                        break;
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
