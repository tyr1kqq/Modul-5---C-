namespace Metod_Next_move_number_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] { 1, 2, 3, 4, 6, 7, 8 };
            var data = 5;
            var num = data;
            BigDataOperation(in arr, ref data);
            GetArrayFromConsole(ref num);
            Console.WriteLine(arr[0]);
            Console.WriteLine(data);

            GetArrayFromConsole(ref num);

            Console.WriteLine("  " + num);



        }
        static void BigDataOperation(in int[] arr, ref int data)
        // in Этот модификатор защищает данные от изменения
        {
            arr[data] = 4;
            data = 7;
        }

        static void GetArrayFromConsole(ref int num)
        {
            num = 6;
            var result = new int[num];
            return;

        }
       
    }
}