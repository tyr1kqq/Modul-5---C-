﻿using System;


class MainClass
{

    static string ShowColor(string username)
    {
        Console.WriteLine("{0} Напишите свой любимый цвет на английском с маленькой буквы" , username);
        string color = Console.ReadLine();

        
        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is yellow!");
                break;
                
        }

        
        
        return color;
    }

    

    public static void Main(string[] args)
    {

        var (name, age) = ("Igor",23) ;
        Console.WriteLine("Your name is - {0}",name);
        Console.WriteLine("your age is - {0}" , age);

        Console.Write("Введите свое имя - ");
        name = Console.ReadLine();

        Console.Write("Введите свой возраст - ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя - {0}",name);
        Console.WriteLine("Ваш возраст - {0}" , age);

       


        var favcolor = new string[3];

            for (int i = 0; i < favcolor.Length; i++)
            {
                favcolor[i] = ShowColor(name) ;
            }

            Console.WriteLine("Ваши любимые цвета - ");
            foreach (var color in favcolor)
            {
                Console.WriteLine(color);
            }

        

    }
    
}