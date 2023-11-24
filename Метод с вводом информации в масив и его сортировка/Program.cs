using System;
 


class Programm
{
    static void Main(string[] args)
    {
        GetArrayFromConsole();
     
    }
    static int[] GetArrayFromConsole()
    {
        var result = new int[5];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }
        int  memory = 0;
       for (int k = 0; k < result.Length;k++)
        {
            for (int j = k+1; j < result.Length; j++)
            {
                if (result[k] > result[j])
                {
                    memory = result[j];
                    result[j] = result[k];
                    result[k] = memory;
                }
            }
        }

       foreach (int mass in result)
        {
            Console.Write(mass + " ");
        }

        return result;
    }
}