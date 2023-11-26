namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var metod = GetArrayFromConsole();
            SortArray(metod);


        }
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("Enter element array {0}  ", i + 1);
                result[i] = Convert.ToInt32(Console.ReadLine());
            }

            return result;
        }
        static int[] SortArray(int[] result)
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
            foreach (int ch in result)
            {
                Console.WriteLine(ch);
            }
            return result;
        }

    }
}