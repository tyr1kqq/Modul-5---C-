﻿namespace Rekursies_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter что-то");

            var str = Console.ReadLine();
            Console.Write("укажите глубину эха - ");
            var deep = int.Parse(Console.ReadLine());

            Echo(str, deep);

        }
        static void Echo(string saidworld , int deep )
        {
            var modif = saidworld;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }
            Console.WriteLine("..." + modif );
             if (deep>1)
            {
                Echo(modif, deep - 1);
            }
            
        }
    }
}