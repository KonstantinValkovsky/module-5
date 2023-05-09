using System.ComponentModel.DataAnnotations;

namespace module_5._2._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] massiv = { 1, -5, 5, -9, 10 };
            ShowArray(massiv, true);
        }

        static void ShowArray(int[] array, bool IsSort = false)
        {
            if (IsSort)
            {
                 Array.Sort(array);
            }

            foreach (int i in array)
            {
                Console.Write(i + ",");
            }
        }
    }
}