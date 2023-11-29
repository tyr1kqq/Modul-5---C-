namespace Rekursies_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter что-то");

            var str = Console.ReadLine();
            Console.Write("укажите глубину эха - ");
            var deep = int.Parse(Console.ReadLine());


            Console.Write("А теперь, факториалы!!! \n Введите число -  ");
            var fact = int.Parse(Console.ReadLine());

            Console.WriteLine (Factorial(fact));
            Echo(str, deep);

            Console.WriteLine("На последок... СТЕПЕНИИИ!!! \n Введите число - ");
            var Number = int.Parse(Console.ReadLine());
            Console.WriteLine("В какую степень будем возводить -");
            var Step =byte.Parse( Console.ReadLine());

            Console.WriteLine(PowerUp(Number,Step));


        }
        static void Echo(string saidworld , int deep )
            // Метод рекурсии , вариация эха с уменьшением отдающего значения на два ( первые две буквы )
        {
            var modif = saidworld;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }
            Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine("..." + modif );
             if (deep>1)
            {
                Echo(modif, deep - 1);
            }

            
        }
        static decimal Factorial(int x)
        {
            if (x==0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
            
        }
        private static int PowerUp(int N, byte pow)
        {
            
            if (pow == 0)
            {
                
                if (pow == 1)
                {
                    return N;
                }
                return 1;
            }
            else
            {             
                   return N  * PowerUp( N  , --pow );      
            }
            
        }

    }
}