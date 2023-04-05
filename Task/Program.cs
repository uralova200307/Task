using System.ComponentModel.Design;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();   

            Console.Write("Enter number: ");
            int row = int.Parse(Console.ReadLine());
            int[] array = new int[row];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
                Console.WriteLine(array[i]);
            }
            if (array[0] == 6 || array[row - 1] == 6)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Main(args);
        }
    }
}