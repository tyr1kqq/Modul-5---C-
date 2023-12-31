﻿using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var array = GetArrayFromConsole(10);
            // num = 3 , это размерность массива

            
            
            ShowArray(array ,true);
            // Вызываем параметр true и выболняем блок if
            


        }
        static int[] GetArrayFromConsole(int num = 10)
        // указываем размерность массива через num = 

        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("Enter element array {0}  ", i + 1);
                result[i] = Convert.ToInt32(Console.ReadLine());
            }



            return result;
        }

        static int[] ShowArray(int[]  array , bool IsSort = false )
        {
            int[] sortedDesc = ShowArray(array);
            int[] soetedDasc = ShowArray(array);
            var temp = array;
            
            if (IsSort)
            {
                SortArray(array, out  s, out soetedDasc);
            }
            foreach (var item in temp)
            {
                Console.WriteLine();
            }

            return temp;
            
                    

        }
        static int[] SortArray(int[] array , out int[] sortArrayDesc , out int[] sortArrayDasc   )
        {
            SortArrayDesc(array);
            SortArrayAsc(array);
            
            
        }

        static int[] SortArrayDesc(int[] result)
        {
            int temp = 0;
            for (int i = 0; i < result.Length; i++)
                for (int j = i + 1; j < result.Length; j++)
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
            Console.WriteLine("Сортировка");
            foreach (int ch in result)
            {
                Console.WriteLine(ch);
            }
            return result;
        }
        static int[] SortArrayAsc(int[] result)
        {
            int temp = 0;
            for (int i = 0; i < result.Length; i++)
                for (int j = i + 1; j < result.Length; j++)
                    if (result[i] < result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
            Console.WriteLine("Обратная сортировка");
            foreach (int ch in result)
            {
                Console.WriteLine(ch);
            }
            return result;
        }

    }
}