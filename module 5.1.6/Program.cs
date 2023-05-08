namespace module_5._1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetArrаyFromConsole();


        }
        static int[] GetArrаyFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++) 
            {
                Console.Write("Введите элемент массива номер {0}: ", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(result);

            foreach (int num in result)
            {
                Console.Write(num + " ");
            }

            return result;
        }
    }
}