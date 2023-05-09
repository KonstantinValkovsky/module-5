namespace module_5._1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] massiv = GetArrаyFromConsole(); 
            Console.WriteLine("\n");
            SortArray(massiv);



        }
        static int[] GetArrаyFromConsole(int num = 5)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("Введите элемент массива номер {0}: ", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            foreach (int arr in result)
            {
                Console.Write(arr + ",");
            }
            return result;
        }

        static int[] SortArray(int[] result)
        {
           
            Array.Sort(result);

            foreach (int num in result)
            {
                Console.Write(num + ",");
            }
            return result;
        }
    }
}