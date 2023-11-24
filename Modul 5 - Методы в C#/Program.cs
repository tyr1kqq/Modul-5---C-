using System;
using System.Reflection.Metadata;

class Programm
{
  public static void Main(string[] args)
    {
       ( string name, string[] dishes) user;
        Console.Write("Ваше имя - ");
        user.name = Console.ReadLine();

        user.dishes = new string[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ваше {0} любимое блюдо - ", i + 1);
            user.dishes[i] = Console.ReadLine();

        }
        Console.ReadKey();

    }
}