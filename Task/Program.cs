using System.ComponentModel.Design;
using System.Transactions;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write(" Enter number: ");
            int.TryParse(Console.ReadLine(), out number);   

            for (int i = 0; i <= number; i++)
            {
                for (int j = 0; j <= number; j++)
                {
                    if (i > j)
                    {
                        Console.Write(" * ");
                    }
                    else 
                    { 
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
          

        }
    }
}