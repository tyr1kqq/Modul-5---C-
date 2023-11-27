using System.Threading.Channels;

namespace area_visibility
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(num1);
            Console.WriteLine(sum());

            if (num1 > 0)
            {
                var num3 = 5;
                Console.WriteLine(num1 + num3 * num2);
            }

        }
        static int num1 = 667;

        static int sum()
        {
            var num2 = 1;
            return num1 - num2 + num3;
            
        }
    }
}