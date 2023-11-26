namespace Metod_Next_move
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var someName = "Egor";
            var someAge = 22;

            Console.WriteLine(someName);

            GetName(ref someName);
            // изменяет переменную someName через ref , вводится в вызове метода и в самом методе 
            ChangeAge(someAge);
            // someAge не изменится , это передача по назначения

            Console.WriteLine(someName);         
            Console.WriteLine(someAge);

            Console.ReadKey();
        }
        static void  GetName(ref string name)
           // передача по сылке , значение поменяется
        {

            Console.Write("Enter your name: ");
            name = Console.ReadLine();
        }

        static void ChangeAge(int age)
            // передача по назначению , переменная не поменяется
        {
            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());
        }
    }
}