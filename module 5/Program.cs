namespace module_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
          (string Name, string[] Dishes ) User;

            Console.Write("Как вас зовут? ");
            User.Name = Console.ReadLine();


            User.Dishes = new string[5];
            for (int i = 0; i < User.Dishes.Length; i++)
            {
                Console.Write("Введите любимое блюдо номер {0}: ", i + 1);
                User.Dishes[i] = Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}